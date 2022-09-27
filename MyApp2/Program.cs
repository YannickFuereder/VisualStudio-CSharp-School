using System;

namespace MyApp2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void PrintMenue(ref int top, int left)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(left, top++);
                switch(i)
                {
                    case 0: 
                        Console.WriteLine("1. Aufgabe");
                        break;
                    case 1:
                        Console.WriteLine("2. Aufgabe");
                        break;
                    case 2:
                        Console.WriteLine("3. Ende");
                        break;
                }
            }
        }

        static Int64 ReadInt(string prefix, int left, ref int top)
        {
            Int64 result = 0;
            string? txt = null;
            do
            {
                Console.SetCursorPosition(left, top);
                Console.Write(prefix);
                txt = Console.ReadLine();
            } while (!Int64.TryParse(txt, out result));
            top++;
            return result;
        }

        static void HandleMenue1(int left, int top)
        {
            Int64 tmpX = ReadInt("X=", left, ref top);

            Int64 tmpY = ReadInt("Y=", left, ref top);
            Console.Clear();
            Console.SetCursorPosition(left, top);
            Console.WriteLine($"Ergebnis={tmpX + tmpY}");
        }

        static void HandleMenue2(int top, int left)
        {
            Console.SetCursorPosition(left, top);
        }


        static void Main(string[] args)
        {
            char? c = null;
            int top = 10,
                origTop = top;
            int left = 10;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            bool clear = true;

            do
            {
                if(clear) Console.Clear();
                clear = true;
                top = origTop;
                PrintMenue(ref top, left);

                Console.SetCursorPosition(left, top++);
                Console.Write("> ");
                c = Console.ReadKey().KeyChar;
                Console.SetCursorPosition(left, ++top);
                switch (c)
                {
                    case '1':
                        Console.Clear();
                        HandleMenue1(left, top);
                        clear = false;
                        break;
                    case '2':
                        HandleMenue2(top, left);
                        break;

                    default:
                        
                        Console.WriteLine("Unbekannte Auswahl!");
                        clear = false;
                        break;

                    case '3': break;
                }
                top--;
                Console.SetCursorPosition(left, top--);

            } while (c != '3');
        }
    }
}