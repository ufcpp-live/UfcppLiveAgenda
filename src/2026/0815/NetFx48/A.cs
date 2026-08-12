public interface IA
{
    // net48 (RuntimeFeature.DefaultImplementationsOfInterfaces がない)だとデフォルト実装(DIM)は使えない。
    // ↓この行はコメントアウトするとコンパイルエラー。
    //void M() { }

    // インターフェイス内の (non-virtual な)静的メソッドは DIM と同世代に実装されたので、
    // 今までは net48 では使えなかった。
    // でも別に runtime 側の対応なくてもこれは大丈夫らしく、なんか C# 15 では認めるらしい？
    public static void S() { }
}
