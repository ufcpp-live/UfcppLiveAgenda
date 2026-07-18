#!
#:property LangVersion=preview

// #:include で dll 参照できるようになったという話なんだけども。
// include なんだ。ref, project, package とある中、dll が include なの迷いそう。ref しそう。

// <Reference Include="A/bin/Debug/net11.0/A.dll" /> 相当。
// 一応確かに Include ではある。
#:include A/bin/Debug/net11.0/A.dll

Console.WriteLine(A.Name);
