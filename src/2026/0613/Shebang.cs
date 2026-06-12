#!
Console.WriteLine("🐈");

// file-based app であると認識してもらうためには冒頭の #! が必須になったっぽい。
// 空 #! (本来の #! の役割ガン無視)でもいいからとりあえずこの2文字が必要。

// #:include も正式に入ったし、
// dotnet pack Lib.cs とかでライブラリ作ったりできるようにもしたらしく、
// それで「Main になってる top-level program はどこ？」検知を軽くするための処置っぽい？
