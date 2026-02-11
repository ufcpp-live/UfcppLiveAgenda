// capacity 指定。
write([with(10), 1, 2, 3]);

// 名前付き引数も利用可能。
write([with(capacity: 10), 1, 2, 3]);

// List<T>(IEnumerable<T>) 引数なやつ。
write([with([1, 2, 3]), 1, 2, 3]);

static void write(List<int> list)
{
    Console.WriteLine($"""
        count: {list.Count}
        capacity: {list.Capacity}
        items: {string.Join(", ", list)}

        """);
}

// IList<T>, ICollection<T> が target-type の時は List<T> 扱いで with が使える。
IList<int> list = [with(5), 1, 2, 3];
ICollection<int> col = [with(5), 1, 2, 3];

// IEnumerable<T> とか相手はダメ。List<T> にはならず。
// IEnumerable<int> e = [with(5), 1, 2, 3];
// IReadOnlyList<int> rol = [with(5), 1, 2, 3];
