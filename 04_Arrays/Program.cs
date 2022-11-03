namespace Arrays;

class Program
{

    static void Main(string[] args)
    {
        char? c;

        do
        {
            Console.Clear();
            PrintMenue();

            c = Console.ReadKey().KeyChar;

            switch (c)
            {
                case '1':
                    Console.Clear();
                    HandleMenue1();
                    break;
                case '2':
                    HandleMenue2();
                    break;

                default:
                    Console.WriteLine("Unbekannte Auswahl!");
                    break;

                case '8': break;
            }
        } while (c != '8');
    }

    static void PrintMenue()
    {
        Console.WriteLine("1. Eindimensionales Array");
        Console.WriteLine("2. Multipliziere Arrays");
        Console.WriteLine("3. Primzahlen");
        Console.WriteLine("4. Zufallszahlen");
        Console.WriteLine("5. Zweidimensionales Array (gleiche Spaltenlänge)");
        Console.WriteLine("6. Zweidimensionales Array (unterschiedliche Spaltenlänge)");
        Console.WriteLine("7. Chess Board");
        Console.WriteLine("8. Ende");
    }

    static void HandleMenue1()
    {
    }

    static void HandleMenue2()
    {
    }

    static void HandleMenue3()
    {
    }

    static void HandleMenue4()
    {
    }

    static void HandleMenue5()
    {
    }

    static void HandleMenue6()
    {
    }

    static void HandleMenue7()
    {
    }
}