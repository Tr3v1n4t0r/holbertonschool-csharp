using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (index >= array.Length || index < 0)
        {
            Console.WriteLength("Index out of range");
            return -1;
        }
        return array[index];
    }
}