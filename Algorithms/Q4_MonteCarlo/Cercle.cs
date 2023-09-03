using System;
namespace Algorithms.Q4_MonteCarlo;
public class Cercle
{
    public double Rayon { get; private set; }
    public Point Centre { get; private set; }

    public Cercle(double rayon)
    {
        if (rayon < 0)
        {
            throw new ArgumentException("Le rayon ne peut pas être négatif.");
        }

        Rayon = rayon;
        Centre = new Point(0, 0); // Le cercle est centré en (0, 0) par défaut.
    }

    public bool IsIn(Point point)
    {
        // Utilisez le théorème de Pythagore pour calculer la distance entre le point et le centre du cercle.
        double distance = Math.Sqrt(Math.Pow(point.X - Centre.X, 2) + Math.Pow(point.Y - Centre.Y, 2));

        // Si la distance est inférieure au rayon du cercle, le point est à l'intérieur du cercle.
        return distance <= Rayon;
    }

    public double CalculerSuperficie()
    {
        return Math.PI * Math.Pow(Rayon, 2);
    }

    public double CalculerCirconference()
    {
        return 2 * Math.PI * Rayon;
    }
}

public class Point
{
    public double X { get; private set; }
    public double Y { get; private set; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}

