// これ今行ける
List<int> x = new([1, 2, 3])
{
    1, 2, 3
};

// ならば with でも…
List<int> y = [with([1, 2, 3]), 1, 2, 3];
