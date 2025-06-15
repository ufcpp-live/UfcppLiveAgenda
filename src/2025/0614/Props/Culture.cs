// see also: ../Culture.cs

// Directory.build.props がちゃんと利いてて、
// (その中に InvariantGlobalization true が書いてある)
// InvariantCulture になるので忌むべき MM/dd/yyyy 形式になるはず。
// (Invariant と名乗ってるものが実際には US カルチャーだという問題。)
Console.WriteLine($"{DateTime.Now}");
