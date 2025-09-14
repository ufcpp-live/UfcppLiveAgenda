// await? t にしたとき、? と null 比較の対象(t)が近い。
await t;

// こっちは foreach? と c が遠い。
foreach (var x in c)
{
}

// 非同期ストリームどうなるん？
// await foreach? にすべき？
await? foreach? (var x in c)
{
}
