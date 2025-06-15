// 「WPF も動いたね」という話。
// こんなもの手書きするの全然覚えてなくて、配信中ちゃんとウィンドウが出る状態まで持っていくのにそこそこ苦労するなど。
// STAThread 属性問題はどうしようもなくて、Program.Main 形式必須。

#:property TargetFramework net10.0-windows
#:property LangVersion preview
#:property UseWPF true
#:property OutputType WinExe

using System.Windows;

public partial class Program
{
    [STAThread]
    static void Main()
    {
        var w = new Window()
        {
            Title = "Hello, WPF!",
            Width = 800,
            Height = 600,
            Content = "Hello, WPF!"
        };

        var app = new Application();
        app.Run(w);
    }
}
