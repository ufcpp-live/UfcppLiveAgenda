#:property InterceptorsNamespaces=App1

using System.Runtime.CompilerServices;

namespace App1
{
    public static partial class Program
    {
        static void Main()
        {
            Console.WriteLine(int.Parse("123"));
        }

        [InterceptsLocation("OldStyleInterceptor.cs", 11, 35)]
        public static int P(string s) => 1234;
    }
}

namespace System.Runtime.CompilerServices
{
#pragma warning disable CS9113
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    file sealed class InterceptsLocationAttribute : Attribute
    {
        public InterceptsLocationAttribute(string filePath, int line, int column) { }
    }
}
