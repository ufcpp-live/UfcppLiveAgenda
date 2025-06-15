// see also: ../PackageReference.cs

// 1個上のフォルダーの同名ファイルとの差は、パッケージのバージョンを書いてない点。
// Directory.Packages.props を参照してる。

#:package MessagePack

byte[] data = [0x81, 0xA2, 0x61, 0x62, 1];

// 一度ビルドするとちゃんとダウンロードしてきた NuGet パッケージのキャッシュもされてるし、
// そのメタデータも読んだ状態になるみたいで、
// vscode 上で ↓ のクラスのソースコードに F12 で飛べたりもする。
var json = MessagePack.MessagePackSerializer.ConvertToJson(data);
Console.WriteLine(json);
