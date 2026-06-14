#!
// closed class = 同一アセンブリ内からしか派生できない代わりに、
// switch 式の網羅性(exhaustiveness)のチェックがかかるようになる。

#:property LangVersion=preview

// closed が付いてる時点で暗黙的に abstract。
var a = new A(); // なのでこの行は「抽象クラスを new できません」エラー。

closed class A;

// 特に「そうじゃないと実装できない」みたいな理由はない。
// 「非 abstract にしたいケースが見当たらない」とのこと

// closed abstract class A; って書き方はエラーに。
// (closed の時点で abstract だから重複。)
