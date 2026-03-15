namespace Cwiczenia2n.Inheritance;

public class B : A
{
    // Dodatkowa właściwość specyficzna tylko dla klasy B
    public int MyProperty { get; set; }

    // Konstruktor klasy B, który inicjalizuje zarówno właściwości klasy bazowej A, jak i własną właściwość MyProperty
    public B(int number, string name, int myProperty) : base(number, name)
    {
        MyProperty = myProperty;
    }

    // Nadpisanie metody DoSomething z klasy A
    public override void DoSomething()
    {
        Console.WriteLine("B");
    }
}