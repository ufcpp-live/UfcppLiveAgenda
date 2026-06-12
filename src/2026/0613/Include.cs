#!

// #:include が正式供用。
// (前回までは ExperimentalFileBasedProgramEnableIncludeDirective オプションが必要だった。)

// 多段 include も可能で、
// 例えば以下の B.cs 内には「#:include A.cs」があるんで A.cs もついてくる。
#:include B.cs

Console.WriteLine(A.Name); // A.cs 内にある。
Console.WriteLine(B.Name); // B.cs 内にある。

// ちなみに、 #:include X は <Compile Include="X" /> 相当。
// 同一プロジェクト内にソースコードを取り込む形になるので internal メンバーにアクセス可能。
