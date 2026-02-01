List<int> x = [with(capacity: 5), 1, 2, 3];

// 中身的に List<T> になるやつは new List<T>(5) でいいのでは。
IList<int> y = [with(capacity: 5), 1, 2, 3];
ICollection<int> z = [with(capacity: 5), 1, 2, 3];
