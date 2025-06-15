// 「ちゃんと言語バージョン見てるよ」デモ。
// C# 9 だと record struct がないので、ちゃんと struct のところにエラーが出る。
//
// 最初に「VS Code かなりちゃんと対応してる」ってのに気づいたのはこのコード書いてる時。

#:property LangVersion 9

{ }

record struct A(int X, int Y);
