namespace Algorithms;
using System;

public static class Monte_Carlo
{

    public static double PiEstimate(int n)
{
    if (n <= 0)
    {
        throw new ArgumentException("Le nombre de points doit être supérieur à zéro.");
    }

    double circleRadius = 1.0; // Rayon du cercle

    Random random = new Random();
    int pointsInCircle = 0;

    for (int i = 0; i < n; i++)
    {
        double x = random.NextDouble() * (2 * circleRadius) - circleRadius;
        double y = random.NextDouble() * (2 * circleRadius) - circleRadius;

        if (x * x + y * y <= circleRadius * circleRadius)
        {
            pointsInCircle++;
        }
    }

    double piEstimate = (double)pointsInCircle / n * 4;
    return piEstimate;
}

}



