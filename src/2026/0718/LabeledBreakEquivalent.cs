#!
#:property LangVersion=preview

// Labeld break/continue 相当のこと、今までは goto が必要。
// できはするけど、ラベルの位置でちょい悩む。

// break 相当の方は「use labeld jump statement」 code fix が出るようになってる。

int[] values = [1, 2, 3];
string[] names = ["A", "B", "C"];

foreach (var value in values)
{
    foreach (var name in names)
    {
        switch (value, name)
        {
            case (1, "a"): break;
            case (2, "b1"): goto InnerBreak; // break Inner;
            case (2, "b2"): goto InnerContinue; // continue Inner;
            case (3, "c1"): goto OuterBreak; // break Outer;
            case (3, "c2"): goto OuterContinue; // continue Outer;
        }
    InnerContinue:;
    }
InnerBreak:;
OuterContinue:;
}
OuterBreak:;
