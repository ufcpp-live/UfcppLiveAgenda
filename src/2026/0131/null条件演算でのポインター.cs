A? a = null;

// これ、今エラーになるけど、本当にエラーにする必要ある？
// ?. の言語仕様どうなってたっけ？
var p = a?.P;

// これが int だった場合:
// var は int? すなわち Nullable<int> 型になる。
var x = a?.X;

// この解釈の場合、 int* は int と同じく値型である。
// であれば、 a?.P は Nullable<int*> 型になるはず。
// Nullable<int*> p2 = a?.P; // コンパイルエラー。ポインターは型引数にできない。

// これが string だった場合:
// var は string? でしょ。
var y = a?.Y;

// この解釈の場合、int* で、それが nullable annotated であるというだけの話。
// int* p = a?.P; // OK でいいんじゃない？

// これが int? だった場合:
// int?? (Nullable<Nullable<int>>) とはならず、int? 素通し。
// 「int? の Nullable 化できない値型」カテゴリーだし、int* 素通しでいいのでは。
var z = a?.Z;

// この解釈の場合、int* 素通しなので
// int* p = a?.P; // 普通に OK。

// var p = a?.P; はこの z に類する解釈になる。
// IntPtr? とは別物だよ！

// しかも、「仕様書の解釈の問題」で片づけられて、「今の仕様のままでも別に受け付けてよかった」という判定。
// バグ修正扱いで OK になりそう。

unsafe struct A
{
    public int* P;
    public int X;
    public string? Y;
    public int? Z;
}
