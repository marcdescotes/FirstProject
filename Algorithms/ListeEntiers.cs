namespace Algorithms;

using System;
using System.Collections.Generic;


class ListeEntiers
{
    static List<int> GetTwoLargestElements(List<int> inputList)
    {

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int num in inputList)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num > secondLargest && num != largest)
            {
                secondLargest = num;
            }
        }

        return new List<int> { largest, secondLargest };
    }

    static void Main6(string[] args)
    {
        List<int> inputList = new List<int> { 5, 10, 3, 8, 15, 7 };
        List<int> result = GetTwoLargestElements(inputList);

        Console.WriteLine("Les deux plus grands éléments sont : " + result[0] + " et " + result[1]);
    }
}
