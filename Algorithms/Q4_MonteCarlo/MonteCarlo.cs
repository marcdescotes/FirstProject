namespace Algorithms
{
    using System;

    public static class Monte_Carlo
    {
        public static double PiEstimate(int n)
        {
            // Vérifier si le nombre de points est inférieur ou égal à zéro
            if (n <= 0)
            {
                // Si n est invalide, lancer une exception avec un message d'erreur
                throw new ArgumentException("Le nombre de points doit être supérieur à zéro.");
            }

            double circleRadius = 1.0; 

            Random random = new Random(); // Créer un objet Random pour générer des nombres aléatoires
            int pointsInCircle = 0; // Initialiser le compteur de points à l'intérieur du cercle

            // Générer n points aléatoires et vérifier s'ils sont à l'intérieur du cercle
            for (int i = 0; i < n; i++)
            {
                // Générer des coordonnées x et y aléatoires dans un carré puis les déplacer au centre du carré en soustrayant circleRadius
                double x = random.NextDouble() * (2 * circleRadius) - circleRadius;
                double y = random.NextDouble() * (2 * circleRadius) - circleRadius;

                // Vérifier si le point (x, y) est à l'intérieur du cercle en utilisant l'équation du cercle
                if (x * x + y * y <= circleRadius * circleRadius)
                {
                    // Si le point est à l'intérieur du cercle, incrémenter le compteur pointsInCircle
                    pointsInCircle++;
                }
            }

            // Calculer une estimation de Pi
            double piEstimate = (double)pointsInCircle / n * 4;

            return piEstimate;
        }
    }
}
