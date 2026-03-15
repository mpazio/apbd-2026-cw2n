namespace Cwiczenia2n.Inheritance;

public abstract class AbstractClass
{
    // Właściwość
    public string Name { get; set; }

    // Konstruktor klasy abstrakcyjnej
    public AbstractClass(string name)
    {
        Name = name;
    }

    // Metoda zaimplementowana (może być dziedziczona bez zmiany)
    public void PerformAction()
    {
        Console.WriteLine($"{Name} is performing an action.");
    }

    // Metoda abstrakcyjna (musi być zaimplementowana w klasach dziedziczących)
    public abstract void SpecificAction();
}