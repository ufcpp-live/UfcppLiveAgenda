// -1 ms とか普通に計算してて出る可能性ある…
var x = new DateTime(1, 1, 1, 1, 1, 1, 999)
    - new DateTime(1, 1, 1, 1, 1, 2);

Console.WriteLine(x == Timeout.InfiniteTimeSpan); // true

await Task.Delay(-10); // 例外

await TimeProvider.Delay(-1); // Infinite くさい… 例外でない…
