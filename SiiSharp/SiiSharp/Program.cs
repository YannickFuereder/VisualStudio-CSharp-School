using System;

namespace SiiSharp
{
    class Program
    {
       /* static void Foo(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("SiiSharp <en/de>");
                Environment.Exit(0);
            }

            string test = null;
            if((test != null) && (test.Length > 0))
            {
                Console.WriteLine(test);
            }



            switch(args[0])
            {
                case "de":
                    Console.WriteLine("Hallo Welt!");
                    break;
                default:
                    Console.WriteLine("Hello World!");
                    break;

            }

            string tmpString = args[0] == "en" ? "Hello World" : "Hallo Welt";
            Console.WriteLine(tmpString);
        }

        static void TextRepeater(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("SiiSharp <10> \"Hello World\"");
                Environment.Exit(0);
            }

            if(!int.TryParse(args[0], out int cnt))
            {
                Console.WriteLine("SiiSharp <10> \"Hello World\"");
                Environment.Exit(0);
            }

            for(int i = 0; i < cnt; i++)
            {
                Console.WriteLine(args[1]);
            }

            foreach (char item in args[1])
            {
                if (item == 'l') continue;
                if (item == 'o') break;
                Console.WriteLine(item);
            }
        }*/

        /*static void Foo2(int x, int y)
        {
            int z = x;
            y = 100;
        }

        static void Main(string[] args)
        {
            int x = 20;
            int m = 100;
            Foo2(x, m);
        }*/
        
        /*static void Foo(ref int x, out int y)
        {
            x = 1001;
            y = 1010;
        }

        static void Main()
        {
            int x = 20;
            int y = 100;
            Foo(ref x, out y);
        }*/

        /*static void Foo(X m, Y n)
        {
            m = new X();
            n = null;
        }

        static void Main()
        {
            X x = new X();
            Y y = new Y();
            Foo(x, y);
        }*/
    }
}