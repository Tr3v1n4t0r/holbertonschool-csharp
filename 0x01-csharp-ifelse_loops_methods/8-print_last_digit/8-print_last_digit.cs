using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        number = Math.Abs(number % 10);
        Console.Write(number);
        return number;
    }
}