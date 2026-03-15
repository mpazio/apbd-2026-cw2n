// Zmienne i operacje na tekście

using Cwiczenia2n.Inheritance;

{
    // Przypisanie zmiennych
    int number = 10;      // Deklaracja zmiennej typu int
    var t = "text";       // Wykorzystanie 'var' dla typu string
    var i = 10;           // 'var' dla liczby całkowitej

    // Operacje na tekstach

    // 1. Łączenie tekstów przy użyciu operatora "+"
    string text = "Text: " + number + ".";  
    Console.WriteLine(text); // Wypisuje: Text: 10.

    // 2. Interpolacja ciągu znaków (String interpolation)
    string textWithDollar = $"Text: {number}.";
    Console.WriteLine(textWithDollar); // Wypisuje: Text: 10.

    // 3. Użycie łańcucha dosłownego (verbatim string literal)
    string textWithAtSign = @"C:\Users"; 
    Console.WriteLine(textWithAtSign); // Wypisuje: C:\Users
}

// Nullable
{
    // Nullable int - zmienna, która może przechowywać wartość liczbową lub być null
    int? nullableInt = null;
    nullableInt = 4; 

    // Nullable Object - obiekt, który może być null lub dowolnym obiektem
    Object? o = null;
    
    if (nullableInt.HasValue)
    {
        Console.WriteLine($"Wartość nullableInt to: {nullableInt.Value}");
    }
    else
    {
        Console.WriteLine("nullableInt jest null");
    }
}

// Kolekcje w C#
{
    // 1. Lista typu int - przechowuje tylko liczby całkowite
    var listOfIntegers = new List<int>();
    listOfIntegers.Add(10); 
    listOfIntegers.Add(20); 
    listOfIntegers.Add(30); 
    Console.WriteLine("Lista liczb:");
    foreach (var num in listOfIntegers)
    {
        Console.WriteLine(num); 
    }

    // 2. Słownik - przechowuje pary klucz-wartość
    var dictionary = new Dictionary<string, int>();
    dictionary.Add("klucz1", 100);
    dictionary.Add("klucz2", 200);

    Console.WriteLine("\nSłownik:");
    foreach (var pair in dictionary)
    {
        Console.WriteLine($"{pair.Key}: {pair.Value}");
    }

    // 3. Kolekcja typu HashSet - przechowuje unikalne elementy
    var uniqueNumbers = new HashSet<int>();
    uniqueNumbers.Add(10);
    uniqueNumbers.Add(20);
    uniqueNumbers.Add(10); // Ponowne dodanie 10 (nie zostanie dodane, bo HashSet przechowuje tylko unikalne wartości)
    Console.WriteLine("\nHashSet (unikalne elementy):");
    foreach (var num in uniqueNumbers)
    {
        Console.WriteLine(num); 
    }
}

// Obsługa wyjątków
{
    try
    {
        // Rzucenie ogólnego wyjątku
        throw new Exception("Wystąpił błąd w aplikacji.");
    }
    catch (Exception e)
    {
        // Obsługa ogólnego wyjątku
        Console.WriteLine($"Błąd: {e.Message}"); // Wynik: Błąd: Wystąpił błąd w aplikacji.
    }
    
    try
    {
        // Specyficzny wyjątek: dzielenie przez zero
        int x = 10;
        int y = 0;
        int result = x / y; // To spowoduje wyjątek DivideByZeroException
    }
    catch (DivideByZeroException e)
    {
        // Obsługa specyficznego wyjątku
        Console.WriteLine($"Błąd: Próba dzielenia przez zero. {e.Message}");
    }
    
    // Blok finally do czyszczenia zasobów
    try
    {
        Console.WriteLine("Rozpoczynam operację...");
        // Symulacja operacji, np. zamknięcia pliku lub połączenia z bazą danych
    }
    catch (Exception e)
    {
        Console.WriteLine($"Błąd: {e.Message}");
    }
    finally
    {
        // Operacje czyszczące, które zawsze się wykonają
        Console.WriteLine("Zasoby zostały zwolnione.");
    }
    
    try
    {
        // Zastosowanie własnego wyjątku
       throw new CustomException("Błąd dostępu do bazy danych.");
    }
    catch (CustomException e)
    {
        // Obsługa własnego wyjątku
        Console.WriteLine($"CustomException: {e.Message}");
    }
}

// Użycie klas
{
    A a = new A(1, "Nazwa");
    A b = new B(1, "NazwaB", 2);

    a.DoSomething();
    b.DoSomething();
}

// Własny wyjątek
public class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
    }
}

