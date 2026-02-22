await M1();
await M2();

var a = new B();
Console.WriteLine(await a.MAsync());

static async Task M1()
{
    await Task.Delay(100);
    Console.WriteLine("M1");
}

static async ValueTask M2()
{
    await Task.Delay(100);
    Console.WriteLine("M2");
}

class A
{
    public virtual async Task<object> MAsync()
    {
        await Task.Delay(100);
        return "A";
    }
}

class B : A
{
    public override async Task<object> MAsync()
    {
        await Task.Delay(100);
        return "B";
    }
}
