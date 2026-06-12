#!

var itemsA = new[]
{
    new { Id = 1, Name = "Alice" },
    new { Id = 2, Name = "Bob" },
    new { Id = 3, Name = "Charlie" },
};

var itemsB = new[]
{
    new { Id = 1, Age = 15 },
    new { Id = 3, Age = 20 },
    new { Id = 5, Age = 25 },
};

foreach (var (a, b) in itemsA.Join(itemsB, a => a.Id, b => b.Id)) // 元々
{
    Console.WriteLine((a.Name, b.Age));
}
Console.WriteLine("---");

foreach (var(a, b) in itemsA.LeftJoin(itemsB, a => a.Id, b => b.Id)) // ちょっと前の preview から
{
    Console.WriteLine((a.Name, b?.Age));
}
Console.WriteLine("---");

foreach (var (a, b) in itemsA.RightJoin(itemsB, a => a.Id, b => b.Id)) // ちょっと前の preview から
{
    Console.WriteLine((a?.Name, b.Age));
}
Console.WriteLine("---");

foreach (var (a, b) in itemsA.FullJoin(itemsB, a => a.Id, b => b.Id)) // 今回から
{
    Console.WriteLine((a?.Name, b?.Age));
}
