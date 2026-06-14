#!

// Directory.build.props で Include してる X.cs を除外する例。
#:include *.cs
#:exclude KeySelector.cs
#:exclude UnionPattern.cs

Console.WriteLine(X.Name); // 除外したので X クラスが見つからずコンパイルエラー。

// 対比として、参考: DirectoryProps.cs

// ちなみに、 #:include X からの #:exclude X するのは「同じやつに対する include/exclude やめろ」とエラーになる。
