namespace Cwiczenia2n.Inheritance;

public interface IMyInterface
{
    void DoSomething();  // Metoda bez implementacji

    string Name { get; set; }  // Właściwość

    // Metoda domyślna - z implementacją
    void DefaultMethod()
    {
        Console.WriteLine("This is a default implementation of DefaultMethod.");
    }
}