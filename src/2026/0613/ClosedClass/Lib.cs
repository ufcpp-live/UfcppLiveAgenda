// 「別アセンブリでは派生クラスを作れない」のデモ用。
#:property OutputType=Library
#:property LangVersion=preview

public closed class A;
public class A1 : A;
public class A2 : A;
