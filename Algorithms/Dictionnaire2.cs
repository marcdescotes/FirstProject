namespace Algorithms;

using System;
using System.Collections.Generic;

class Dictionnaire2
{
    static Dictionary<int, List<int>> InvertDictionaryWithLists(Dictionary<int, int> inputDict)
    {
        Dictionary<int, List<int>> outputDict = new Dictionary<int, List<int>>();

        foreach (KeyValuePair<int, int> kvp in inputDict)
        {
            int value = kvp.Value;
            if (!outputDict.ContainsKey(value))
            {
                outputDict[value] = new List<int>();
            }

            outputDict[value].Add(kvp.Key);
        }

        return outputDict;
    }

    static void Main(string[] args)
    {
        Dictionary<int, int> inputDict = new Dictionary<int, int>
        {
            [5] = 105,
            [3] = 105,
            [4] = 104
        };

        Dictionary<int, List<int>> outputDict = InvertDictionaryWithLists(inputDict);

        Console.WriteLine("\nOutput Dictionary:");
        foreach (KeyValuePair<int, List<int>> kvp in outputDict)
        {
            Console.Write($"[{kvp.Key}] = ");
            foreach (int value in kvp.Value)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
    }
}
