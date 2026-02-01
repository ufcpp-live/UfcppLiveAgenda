// OK
ref partial struct S1;

// これも OK でいいのでは？
// (ここ数年毎年 working set に入っては、結局実装されてないのが続いてる。)
partial ref struct S2;

// 元からダメ。
// ref と partial は破壊的変更を避けるために順序に制限入れた。
ref public struct S3;
ref readonly struct S4;

// C# 1 時代にこの型があったら…
class @partial { }

// これが破壊的変更にならないように C# 2 では partial の位置を class 直前に限定。
// 「partial class とか partial struct の2単語で1つのキーワード」方式に近い。
// yeild return の yield と一緒。
