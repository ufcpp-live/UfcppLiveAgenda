// #:sdk で .Web な SDK 参照も可能。
// ASP.NET Minimal API と組み合わせたらかなり小さい「最低限のデモ」が可能に。

#:sdk Microsoft.NET.Sdk.Web

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
