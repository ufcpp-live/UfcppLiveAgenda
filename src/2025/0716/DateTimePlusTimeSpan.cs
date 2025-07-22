Console.WriteLine(DateTime.MaxValue.Year); // 9999
Console.WriteLine(TimeSpan.MaxValue.TotalDays / 365); // 9999 over

// overflow する。例外。
var x = DateTime.MinValue + TimeSpan.MaxValue;
