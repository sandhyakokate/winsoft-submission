// Q1: Replace each array element by its corresponding rank
//   Given an array of distinct integers, replace each array element by its corresponding rank in the array.

// The minimum array element has the rank 1; the second minimum element has a rank of 2, and so on… For example,

// Input:  { 10, 8, 15, 12, 6, 20, 1 } 
// Output: { 4, 3, 6, 5, 2, 7, 1 }

// ------>

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void ReplaceWithRank(List<int> arr)
    {
        // 1. Create a sorted copy of the array for efficient ranking (ensures uniqueness)
        List<int> sortedArr = new List<int>(arr);
        sortedArr.Sort();

        // 2. Use a dictionary to efficiently store element ranks
        Dictionary<int, int> elementRanks = new Dictionary<int, int>();
        int rank = 1; // Rank starts from 1

        // 3. Assign ranks to elements in the sorted copy
        foreach (int num in sortedArr)
        {
            if (!elementRanks.ContainsKey(num))
            {
                elementRanks[num] = rank;
                rank++;
            }
        }

        // 4. Replace elements in the original array with their ranks
        for (int i = 0; i < arr.Count; i++)
        {
            arr[i] = elementRanks[arr[i]];
        }
    }

    static void Main(string[] args)
    {
        List<int> arr = new List<int> { 5,8,6,1,4,9 };
        ReplaceWithRank(arr);

        Console.Write("Original array with ranks: ");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

