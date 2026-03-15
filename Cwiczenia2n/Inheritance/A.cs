namespace Cwiczenia2n.Inheritance;

public class A : IMyInterface
{
    // Właściwości klasy
    public int Number { get; set; }  // Dodatkowa właściwość specyficzna dla klasy A
    public string Name { get; set; }  // Implementacja właściwości z interfejsu
    public A(int number, string name)
    {
        Number = number;
        Name = name;
    }

    public virtual void DoSomething()
    {
        Console.WriteLine("A");
    }
}