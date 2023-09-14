using System;

class Program
{
    static void Main()
    {
        string inputString = "Hello World and Coders"; // You can change this to any string
        string reversedString = FirstReverse(inputString);
        Console.WriteLine("Reversed String: " + reversedString);
    }

    static string FirstReverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
