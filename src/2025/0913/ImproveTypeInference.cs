// 長い。いや。
var x = new X<System.Collections.Generic.Dictionary<string, System.Collections.BitArray>>();

// target-typed:
M(new X()); // これは new X<>() でもいいかも。
M(X.Create()); // こっちが X<>.Create() きもくない？

// ここが IX<> じゃなくて X<> だったら new() 推論は効く。
// でも、あとからインターフェイスに変えた瞬間ダメに。
static void M(IX<System.Collections.Generic.Dictionary<string, System.Collections.BitArray>> x) { }

interface IX<T>;
class X<T> : IX<T>
{
    // これも non-generic X 用意するのめんどくない？
    public static IX<T> Create() => new X<T>();
}

// 今までこれを強いられてた(X<T> に対して non-generic X も書くはめに)。
//
//class X
//{
//    public static IX<T> Create<T>() => new X<T>();
//}

// そもそもなんでこんな話がでたかというと、union の一環。
Result<int> x = .Some;

union Result<T> allows Some<T>, None;
