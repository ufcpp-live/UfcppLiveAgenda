#!

// この行を消すとそもそもエラーにならない。
// 旧 async 時代は __arglist 使えてた。
#:property Features=$(Features);runtime-async=on

await MAsync();

partial class Program
{
    static async Task MAsync()
    {
        await Task.Delay(100);

        // 「uses a feature that is not supported by runtime async.」って一文に、
        // 前までは currently (今は)って単語付けちゃってたけど、将来もサポートするつもりないとのことで単語削ったらしい。
        //
        // ちなみに ja リソースでは「現在ランタイム非同期でサポートされていない機能を使用しています。」
        // いままだついてるけど、GA までには「現在」が削られると思う。
        M(__arglist(1, 2, 3));
    }

    static void M(__arglist)
    {
        _ = new ArgIterator(__arglist);
    }
}
