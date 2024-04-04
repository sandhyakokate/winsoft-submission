// Q3:Find non-repeating characters in a string 

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        NonRepeating(input);
    }

    static void NonRepeating(string s)
    {
        int size = s.Length;
        int[] nonRepeatingChar = new int[size];
        int index = 0;
        
        for (int i = 0; i < size; i++)
        {
            int count = 0;
            for (int j = 0; j < size; j++)
            {
                if (j != i)
                {
                    if (s[i] != s[j])
                    {
                        count++;
                    }
                }
            }
            if (count == size - 1)
            {
                Console.Write(s[i] + " ");
            }
        }
    }
}