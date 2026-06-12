#!

// #:ref で「他の file-based app を参照」ができるみたい。
// (今回プレビュー機能らしいので ExperimentalFileBasedProgramEnableRefDirective フラグが必要。)
#:property ExperimentalFileBasedProgramEnableRefDirective=true
#:ref UnionPattern.cs

// 挙動としては「dotnet build X 後に <ProjectReference Include="X" />」っぽい。
// dll が分かれるので public なものだけ触れる。

Console.WriteLine(nameof(A)); // これは OK。UnionPattern.cs 内に public record A がいる。
//Console.WriteLine(nameof(U)); // これは「'U' はアクセスできない保護レベルになっています」エラー。
