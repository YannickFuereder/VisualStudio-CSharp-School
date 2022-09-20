using System;

namespace SiiSharp
{
    class Program
    {
        static void Foo(string[] args)
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
        }

        static void Main(string[] args)
        {
            //Foo(args);
            TextRepeater(args);
        }
    }
}