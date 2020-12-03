using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int total = 0;
        HashSet<int> numbers = new HashSet<int>();
        foreach (int val in myList)
        {
            if (!numbers.Contains(val))
            {
                total += val;
                numbers.Add(val);
            }
        }
        return total;
    }
}