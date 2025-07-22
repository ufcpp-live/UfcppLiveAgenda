using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

//lang=Json
var x = JsonSerializer.Deserialize<Point>("""
{"X":1,"Y":2,}
""");

//lang=JsonStrict
var y = JsonSerializer.Deserialize<Point>("""
{"X":1,"Y":2,}
""");

var z = JsonSerializer.Deserialize<Point>("""
{"X":1,"Y":2,}
"""); // strict の方がデフォルトになった？いつからだろ？？

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

