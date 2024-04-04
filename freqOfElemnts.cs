// Q4:You are given an array of integers. 
// Write a C# program to find the frequency of each unique element in the array and 
// store the results in a dictionary where the key is the element and the value is its frequency.
// Then, print the elements and their frequencies.

// Example:
// Input:
// int[] numbers = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

// Output:
// Element: 1, Frequency: 1
// Element: 2, Frequency: 2
// Element: 3, Frequency: 3
// Element: 4, Frequency: 4


// ---->
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter integers separated by spaces:");
        string input = Console.ReadLine();
        
        // Split the input string by spaces and convert it to an array of integers
        string[] numberStrings = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = Array.ConvertAll(numberStrings, int.Parse);

        // Dictionary to store frequencies
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        // Count frequencies of each unique element
        foreach (int num in numbers)
        {
            if (!frequencyMap.ContainsKey(num))
                frequencyMap[num] = 1;
            else
                frequencyMap[num]++;
        }

        // Print elements and their frequencies
        Console.WriteLine("Element Frequencies:");
        foreach (var kvp in frequencyMap)
        {
            Console.WriteLine($"Element: {kvp.Key}, Frequency: {kvp.Value}");
        }
    }
}