namespace Algorithms;
using System;


public static class MathUtils
{


    public static void Main(string[] args)
    {



    }
    
    public static double PiEstimate(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentException("Le nombre de points doit être supérieur à zéro.");
        }

        Random random = new Random();
        int pointsInsideCircle = 0;

        for (int i = 0; i < n; i++)
        {
            double x = random.NextDouble() * 2 - 1; // Valeur aléatoire entre -1 et 1
            double y = random.NextDouble() * 2 - 1; // Valeur aléatoire entre -1 et 1

            // Vérifie si le point est à l'intérieur du cercle unité (rayon = 1)
            if (x * x + y * y <= 1)
            {
                pointsInsideCircle++;
            }
        }

        // Utilise la formule de Monte Carlo pour estimer 𝜋
        double piEstimation = (double)pointsInsideCircle / n * 4;
        return piEstimation;
    }
}


