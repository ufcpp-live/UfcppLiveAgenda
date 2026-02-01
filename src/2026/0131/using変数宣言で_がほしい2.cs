
static void M1()
{
    using var m = new MemoryStream();
}

static void M2(MemoryStream m)
{
    using (m)
    {

    }

    // こっちも
    // using m; したい…
    // using var _dummy1 = m1; // 今だとこう
    // using var _dummy2 = m2; // 今だとこう

    // 提案: discard
    // using _ = m1; // 今だとこう
    // using _ = m2; // 今だとこう
}
