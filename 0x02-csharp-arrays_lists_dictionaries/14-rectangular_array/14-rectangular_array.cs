using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] box = new int[5, 5];
        box[2, 2] = 1;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (j == 4)
                    Console.WriteLine(box[i, j]);
                else
                    Console.Write($"{box[i, j]} ");
            }
        }
    }
}