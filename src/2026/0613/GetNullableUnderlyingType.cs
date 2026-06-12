#!

Console.WriteLine(typeof(string).GetNullableUnderlyingType()); // null

Console.WriteLine(typeof(int?).GetNullableUnderlyingType()); // typeof(int)

// Nullable.GetUnderlyingType(t) だと内部で t.IsGenericType && ReferenceEquals(t.GetGenericTypeDefinition(), typeof(Nullable<>)) みたいになるのが重たいらしい。
// それに RuntimeType でないと動かなくて MetadataLoadContext とか経由した時にまずいらしい。

// Type 型への abstract メンバー追加なので一応、Type 派生の自作の型作ってる人にとっては破壊的変更。
