namespace DrawCharacter;
class DrawCharacter
{
    static void Main(string[] args)
    {
        if (args.Length <= 3)
        {
            Console.WriteLine("Ex. usage: DrawCharacter 11 10 k");
            return;
        }

        if (!int.TryParse(args[0], out int x))
        {
            Console.WriteLine("Invalid Integer: DrawCharacter <-- HERE");
            return;
        }

        if (!int.TryParse(args[1], out int y))
        {
            Console.WriteLine("Invalid Integer: DrawCharacter " + args[0] + " <-- HERE");
            return;
        }

        if (args[2].Length > 1)
        {
            Console.WriteLine("Invalid Character length: DrawCharacter " + args[0] + " " + args[1] + " <-- HERE");
            return;
        }

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.Gray;

        Console.Clear();

        Console.SetWindowSize(x * 2, y * 2);

        for (int i = 0; i < y; i++)
        {
            Console.SetCursorPosition((x / 2), (y / 2) + i);

            for (int j = 0; j < x; j++)
            {
                Console.Write(args[2]);
            }
        }

        Thread.Sleep(Timeout.Infinite);
    }
}
