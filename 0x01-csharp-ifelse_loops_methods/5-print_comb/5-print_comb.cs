using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 98; i++)
            Console.Write("{0:D2}, ", i);
        Console.WriteLine("99");
    }
}