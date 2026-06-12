#!
#:property LangVersion=preview

var items = new[]
{
    (Id: 1, Name: "Alice"),
    (Id: 2, Name: "Bob"),
    (Id: 3, Name: "Charlie"),
};

var comparer = EqualityComparer<(int Id, string Name)>.Create(t => t.Id);
HashSet<(int Id, string Name)> set = [with(comparer), ..items];

Console.WriteLine(set.Contains((1, ""))); // true
Console.WriteLine(set.Contains((5, ""))); // false

// そういや Comparison<T> デリゲートを受け取るようなコンストラクターとか ToHashSet() がなく、
// キーだけの比較とかやりたかったら自作 IEqualityComparer が必要だった？
