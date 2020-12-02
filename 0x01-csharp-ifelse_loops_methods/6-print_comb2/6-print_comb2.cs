using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 8; i++)
        {
            for (int j = i + 1; j <= 9; j++)
            {
                if (i != j && i != 8)
                    Console.Write("{0}{1}, ", i, j);
            }
        }
        Console.WriteLine("89");
    }
}