// パッケージ参照のデモ用。
// csproj の PackageReference 相当。

// see also: Props/PackageReference.cs
// (ManagePackageVersionsCentrally も利用可能。)

#:package MessagePack 3.1.4

byte[] data = [0x81, 0xA2, 0x61, 0x62, 1];

// 一度ビルドするとちゃんとダウンロードしてきた NuGet パッケージのキャッシュもされてるし、
// そのメタデータも読んだ状態になるみたいで、
// vscode 上で ↓ のクラスのソースコードに F12 で飛べたりもする。
var json = MessagePack.MessagePackSerializer.ConvertToJson(data);
Console.WriteLine(json);
