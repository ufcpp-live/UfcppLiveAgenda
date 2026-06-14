// 今のところ標準ライブラリ側にない属性を手作業追加が必要。たぶんそのうち解消。
// このフォルダーでは Directory.build.props で全ファイルで ClosedAttribute.cs を参照。

namespace System.Runtime.CompilerServices;

class ClosedAttribute : Attribute;
