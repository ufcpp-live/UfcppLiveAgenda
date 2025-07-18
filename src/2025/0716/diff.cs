#!/usr/bin/env dotnet

// ↑ dotnet だけでよくなった(前回時点だと dotnet-run)
// (コマンドライン上でも dotnet app.cs だけで run できるようになってる。)

// property、プロパティ名と値の間に = を入れることに。
#:property LangVersion=preview

// package 参照、パッケージ名とバージョンの間に @ 入れることに。
#:package MessagePack@3.1.4

// #:project ディレクティブ追加。プロジェクト参照。
#:project SubProject/SubProject.csproj

byte[] data = [0x81, 0xA2, 0x61, 0x62, 1];
var json = MessagePack.MessagePackSerializer.ConvertToJson(data);
Console.WriteLine(json);

// 同じフォルダー内の他のファイルは今も参照しないみたい。
//var a = new A(1, 2);

// ちゃんとプロジェクト参照できてるか確認。
var a = new SubProject.A(1, 2);
Console.WriteLine(a);
