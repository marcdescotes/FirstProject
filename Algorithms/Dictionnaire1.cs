namespace Algorithms;

using System;
using System.Collections.Generic;

class Dictionnaire1
{
    static Dictionary<int, int> InvertDictionary(Dictionary<int, int> inputDict)
    {
        Dictionary<int, int> outputDict = new Dictionary<int, int>();

        foreach (KeyValuePair<int, int> kvp in inputDict)
        {
            outputDict[kvp.Value] = kvp.Key;
        }

        return outputDict;
    }

    static void Main7(string[] args)
    {
        Dictionary<int, int> inputDict = new Dictionary<int, int>
        {
            [5] = 105,
            [3] = 103,
            [4] = 104
        };

        Dictionary<int, int> outputDict = InvertDictionary(inputDict);

        Console.WriteLine("\nOutput Dictionary:");
        foreach (KeyValuePair<int, int> kvp in outputDict)
        {
            Console.WriteLine($"[{kvp.Key}] = {kvp.Value}");
        }
    }
}