IEnumerable<int> x = [1, 2];

// [..x] にしろとアナライザーさんが言ってくる。
int[] y = [.. x];

M(x.ToArray());
M([.. x]); // どうだろうねぇ…

M([.. from i in x select i * i]); // どうだろうねぇ…

M([..
    from i in x
    from j in x
    select i * j
    ]); // どうだろうねぇ…

static void M(int[] x)
{
}
