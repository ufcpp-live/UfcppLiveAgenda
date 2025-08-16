#:property LangVersion=preview

using System.Linq.Expressions;

// これはもともと行ける。
Action<string> a2 = s => s.Contains('a', comparer: null);

// これは C# 14 から行ける。
Expression<Action<string>> e2 = s => s.Contains('a', comparer: null);

// 単に「式ツリーを追加した当時、named args がなかった」というだけ。
// 式ツリーで使える文法を増やすと Expression 型を足さないとダメなことがあって下手に対応文法増やせない。
// なので C# に新機能を追加する際、「式ツリー内では使えない」状態を保つことが多い。

// とはいえ、named args は(上記の例でいうと)単に Contains('a', null) に展開されるだけなので、
// 既存の Expression 型で表現可能。

// できない理由もないけど、できてうれしい需要も低くて放置されてた。
// 意図的にかけてた制限を消して、単体テストを足す程度の作業でできたのでこの度修正することに。
