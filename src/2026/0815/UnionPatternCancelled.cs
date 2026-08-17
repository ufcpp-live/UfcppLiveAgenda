#!
#:property LangVersion=preview

M(1);

static int M(OneOrMany x) => x switch
{
    int => 1, // x.Value is int 相当
    OneOrMany=> 2, // x is OneOrMany 相当
    // ※ .NET 11 Preview 7 で一瞬この仕様が入ったものの、やっぱり取りやめに。
};

readonly union OneOrMany(int, IEnumerable<int>) : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        return this switch
        {
            int single => new[] { single }.AsEnumerable().GetEnumerator(),

            // この IEnumerable<int> のケースは this is ... なのか this.Value is ... なのか…
            // 下手したら無限再帰する。
            IEnumerable<int> many => many.GetEnumerator(),
        };
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
}
