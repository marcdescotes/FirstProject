using System;
namespace Algorithms.Q4_MonteCarlo;
public class Square
{
    public double Cote { get; private set; }

    public Square(double cote)
    {
        if (cote < 0)
        {
            throw new ArgumentException("La longueur du côté ne peut pas être négative.");
        }

        Cote = cote;
    }

    public bool IsIn(Point point)
    {
        // Vérifie si le point est à l'intérieur du carré.
        double halfCote = Cote / 2;
        double absX = Math.Abs(point.X);
        double absY = Math.Abs(point.Y);

        return absX <= halfCote && absY <= halfCote;
    }

    public double CalculerAire()
    {
        return Math.Pow(Cote, 2);
    }

    public Point RandomPoint(Random random)
    {
        // Génère des coordonnées X et Y aléatoires à l'intérieur du carré.
        double halfCote = Cote / 2;
        double randomX = (random.NextDouble() * Cote) - halfCote;
        double randomY = (random.NextDouble() * Cote) - halfCote;

        return new Point(randomX, randomY);
    }
}

