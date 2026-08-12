#!
// updated-memory-safety-rules フィーチャーオプション入れると unsafe がらみが新ルールに変化。
#:property Features=$(Features);updated-memory-safety-rules

// (ただし、現状は LangVersion=preview 必要。たぶん来月には 15 でも行けるはず。)
#:property LangVersion=preview

#:property AllowUnsafeBlocks=true

using System.Runtime.InteropServices;

// 新ルールでは dereference するまでは unsafe 不要。
// int* 引数使うのも、null を渡すだけなのも safe。

U(null);

static void U(int* p) { }

unsafe
{
    // unsafe が付いてるメソッドなので unsafe ブロック内に入れないとダメ。
    DllImport.printf("Hello, %s!\n", __arglist("world"));
}

// こっちは unsafe ブロック不要。
_ = DllImport.tan(1.0);

static class DllImport
{
    // extern なメソッドには unsafe か safe のどちらかの修飾子をつけろとのこと。
    // まあ実際、大部分は unsafe。
    [DllImport("msvcrt", CallingConvention = CallingConvention.Cdecl)]
    public static unsafe extern int printf(string format, __arglist);

    // 「まあこんなの unsafe にならないだろ」っていう DllImport もそこそこあるので、その場合は safe を付ける。
    [DllImport("ucrtbase.dll", CallingConvention = CallingConvention.Cdecl)]
    public static safe extern double tan(double x);}

#if false
static partial class LibraryImport
{
    // 「じゃあ LibraryImport どうすんの…」という話あり。
    // これのためだけに、extern じゃないものにも unsafe/safe をつけれるようにしようという話あり。
    // (おそらく来月にはそうなってる。)
    [LibraryImport("msvcrt", StringMarshalling = StringMarshalling.Utf8)]
    public static unsafe extern int printf(string format, __arglist);
}
#endif
