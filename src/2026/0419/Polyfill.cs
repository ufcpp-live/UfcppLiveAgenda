namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false)]
public class UnionAttribute : Attribute;

public interface IUnion
{
    object? Value { get; }
}
