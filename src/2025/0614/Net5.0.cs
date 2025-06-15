// TargetFramework 変えて動くか試そうとしたんだけど、
// これやると実行も .NET 5.0 で実行しようとして、マシンにインストールしてないと実行に失敗する。
// (.NET 5 だともうサポートも切れてるし…)
//
// 試してないけどもおそらく、global.json で sdk version 辺りを指定すれば動かせるかも。

#:property TargetFramework net5.0
#:property LangVersion preview

Console.WriteLine("🐈");
