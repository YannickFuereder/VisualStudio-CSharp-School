using System.Collections;

namespace Arrays;

internal class Util
{
    static void InitArr(int[] arr, int val)
    {
        arr = new int[val];
    }

    static void PrintArr(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + ",");
        }
    }

    static int[] MultiplyArr(int[] arr1, int[] arr2)
    {
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = arr1[i] * arr2[i];
        }

        return arr1;
    }

    static int[] CreatePrimeNumbers(int val)
    {
        List<int> primes = new();
        primes.Add(2);
        primes.Add(3);
        while (primes.Count < val)
        {
            int nextPrime = (int)(primes[primes.Count - 1]) + 2;
            while (true)
            {
                bool isPrime = true;
                foreach (int n in primes)
                {
                    if (nextPrime % n == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    break;
                }
                else
                {
                    nextPrime += 2;
                }
            }
            primes.Add(nextPrime);
        }
        return primes.ToArray();
    }

    static int[] CreateRandomNumbers(int count, int maxVal)
    {
        Random rand = new();

        int[] arr = new int[count];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(maxVal);
        }

        return arr;
    }

    static void InitTab(int[,] tab, int val)
    {
        tab = new int[val,val];
    }

    static void PrintTab(int[,] tab)
    {
        for (int i = 0; i < tab.GetLength(0); i++)
        {
            for (int y = 0; y < tab.GetLength(1); y++)
            {
                Console.Write(tab[i, y]);
            }

            Console.WriteLine();
        }
    }

    static void InitTab(int[][] tab, int val)
    {
        tab = new int[val][];
    }

    static void PrintTab(int[][] tab)
    {

    }

    static char[,] CreateChessBoard()
    {

    }

    static void PrintTab(char[,] tab)
    {

    }
}
