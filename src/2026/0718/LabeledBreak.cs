#!
#:property LangVersion=preview

// for, foreach, while とかの前にラベルを付けて、そこに向かって break X; や continue X; できるようになった。

int[] values = [1, 2, 3];
string[] names = ["A", "B", "C"];

Outer: foreach(var value in values)
{
    Inner: foreach (var name in names)
    {
        switch (value, name)
        {
            case (1, "a"): break; // switch を抜けるだけ
            case (2, "b1"): break Inner; // Inner ループを抜ける
            case (2, "b2"): continue Inner; // Inner ループの次の反復に進む
            case (3, "c1"): break Outer; // Outer ループを抜ける
            case (3, "c2"): continue Outer; // Outer ループの次の反復に進む
        }
    }
}
