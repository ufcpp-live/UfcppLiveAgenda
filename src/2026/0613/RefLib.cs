#!

// #:ref で「他の file-based app を参照」ができるみたい。
// 参照先が OutputType=Library。
#:property ExperimentalFileBasedProgramEnableRefDirective=true
#:ref Lib.cs

Console.WriteLine(Lib.Name);
