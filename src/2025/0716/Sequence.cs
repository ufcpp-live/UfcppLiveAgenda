foreach (var x in Enumerable.Sequence(1, 5, 2))
{
    Console.WriteLine(x);
    break;
}

foreach (var x in Enumerable.InfiniteSequence(1, 0x7fff_ffff))
{
    Console.WriteLine(x);
    break;
}

for (int i = 1; ; i++)
{
    // あれ、でもこの方が簡潔…
}

