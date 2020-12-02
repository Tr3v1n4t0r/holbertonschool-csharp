using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = i;
            if (i == size - 1)
                Console.Write(i);
            else
                Console.Write("{0} ", i);
        }
        Console.WriteLine();
        return arr;
    }
}