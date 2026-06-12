#!
#:property LangVersion=preview

// 今回のアプデ(.NET 11 preview 5)で使えるようになったという触れ込みなものの…
// 「 コンパイラが必要とするメンバー 'System.Runtime.CompilerServices.ClosedAttribute..ctor' がありません」がどうやっても解消できず。
// 直前での仕様変更の影響でおかしくなってるのかなぁという予想。
// IsClose 属性にリネームしたり、DerivedTypes プロパティを生やしたりとかが直近でありそう。
closed class A;

class A1 : A;
