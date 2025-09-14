using A = int; // 合法。top-level では using エイリアス。
using _ = string; // これも合法。

{
    // やりたいことは using discard
    using _ = disposable;

    // 今はこう書かざるを得ない。
    // この _ は discard ではなくて普通の変数。
    using var _ = disposable;
    // _1, _2, _.....
}

// もしかしたら
// top-level 限定でダメってことにするかも。
using _ = disposable;

// _ いい加減に識別子としての利用禁止にできない？

// いい加減、これ、警告にしたら？
//class _;

// これは今警告出すようになったのにねぇ…
// (小文字 ASCII 始まりの識別子はキーワードと被る。新キーワード足したくなった時の障害になりがち。)
class abc;
