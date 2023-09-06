namespace Algorithms;
using System;

public static class MathUtils
{
    public static void Main(string[] args)
    {
    // Nombre de points à générer pour l'estimation de Pi
    int[] numberOfPoints = { 1000, 10000, 100000, 1000000 };

    // Test de l'estimation de Pi pour différents nombres de points
    foreach (int n in numberOfPoints)
    {
        double piEstimation = PiEstimate(n);
        Console.WriteLine($"Estimation de Pi avec {n} points : {piEstimation}");
    }

    // Attente pour voir les résultats dans la console
    Console.ReadKey();
    }
    
    public static double PiEstimate(int n)
    {
        // Vérifier si le nombre de points (n) est inférieur ou égal à zéro. Si c'est le cas, une exception est lancé
        if (n <= 0)
        {
            throw new ArgumentException("Le nombre de points doit être supérieur à zéro.");
        }

        // Création d'un générateur de nombres aléatoires
        Random random = new Random();
        int pointsInCircle = 0; // Variable pour compter les points à l'intérieur du cercle

        // Boucle qui génère n points aléatoires et vérifie s'ils sont à l'intérieur du cercle
        for (int i = 0; i < n; i++)
        {
            double x = random.NextDouble() * 2 - 1; // Génère une valeur aléatoire entre -1 et 1 pour la coordonnée x
            double y = random.NextDouble() * 2 - 1; // Idem pour y

            // Vérifier si le point est à l'intérieur du cercle en utilisant Pythagore
            if (x * x + y * y <= 1)
            {
                pointsInCircle++; // Incrémente le compteur si le point est à l'intérieur du cercle
            }
        }

        // Formule de MonteCarlo pour estimer la valeur de pi
        double piEstimate = (double)pointsInCircle / n * 4;
        return piEstimate;
    }
}



