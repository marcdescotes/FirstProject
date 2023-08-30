namespace Algorithms;
using System;

public class Q1_Moyenne
{
    public static void Main(string[] args)
    {
        List<double> numbers = new List<double> { 3.1, 42.42, 151.60, 9.59, 11.31 };
        double average = CalculateAverage(numbers);
        Console.WriteLine($"La moyenne est : {average}");
    }


    public static double CalculateAverage(List<double> numbers)
    {
        if (numbers.Count == 0)
        {
            return 0; // Moyenne indéfinie pour une liste vide, retourne 0 pour éviter les erreurs.
        }

        double sum = 0;
        foreach (double num in numbers)
        {
            sum += num;
        }

        double average = sum / numbers.Count;
        return average;
    }

}




