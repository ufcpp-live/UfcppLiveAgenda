#:property LangVersion=preview

int[] a = [1, 2, 3];
a *= 2;

foreach (var x in 2 * a)
    Console.WriteLine(x);

public static class Operators
{
    extension<TElement>(TElement[] source) where TElement : System.Numerics.INumber<TElement>
    {
        public static TElement[] operator *(TElement[] vector, TElement scalar) { TElement[] x = [..vector]; x *= scalar; return x; }
        public static TElement[] operator *(TElement scalar, TElement[] vector) => vector * scalar;
        public void operator *=(TElement scalar) { foreach (ref var x in source.AsSpan()) x *= scalar; }
        public static bool operator ==(TElement[] left, TElement[] right) { if (left.Length != right.Length) return false; for (var i = 0; i < left.Length; ++i) if (left[i] != right[i]) return false; return true; }
        public static bool operator !=(TElement[] left, TElement[] right) { if (left.Length == right.Length) return false; for (var i = 0; i < left.Length; ++i) if (left[i] == right[i]) return false; return true; }
    }
}
