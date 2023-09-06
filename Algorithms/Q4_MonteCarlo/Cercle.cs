using System;
namespace Algorithms.Q4_MonteCarlo;
public class Cercle
{
    // Définition de la classe Cercle avec des propriétés pour le rayon et le centre du cercle
    public double Rayon { get; private set; }
    public Point Centre { get; private set; }

    // Constructeur de la classe Cercle prenant le rayon comme paramètre
    public Cercle(double rayon)
    {
        // Vérification si le rayon est négatif. Si c'est le cas, une exception est lancé.
        if (rayon < 0)
        {
            throw new ArgumentException("Le rayon ne peut pas être négatif.");
        }

        // Initialisation des propriétés Rayon et Centre avec les valeurs passées en paramètre
        Rayon = rayon;
        Centre = new Point(0, 0);
    }

    // Vérifier si un point donné est à l'intérieur du cercle
    public bool IsIn(Point point)
    {
        // Calculer la distance entre le point et le centre du cercle.
        double distance = Math.Sqrt(Math.Pow(point.X - Centre.X, 2) + Math.Pow(point.Y - Centre.Y, 2));

        // Si la distance est inférieure ou égale au rayon du cercle, le point est à l'intérieur
        return distance <= Rayon;
    }

    // Calculer la superficie du cercle
    public double CalculerSuperficie()
    {
        // Calculer la superficie d'un cercle
        return Math.PI * Math.Pow(Rayon, 2);
    }

    // Calculer la circonférence du cercle
    public double CalculerCirconference()
    {
        // Calculer la circonférence d'un cercle
        return 2 * Math.PI * Rayon;
    }
}

// Définition de la classe Point avec des propriétés pour les coordonnées X et Y
public class Point
{
    public double X { get; private set; }
    public double Y { get; private set; }

    // Constructeur de la classe Point prenant les coordonnées X et Y comme paramètres
    public Point(double x, double y)
    {
        // Initialisation des propriétés X et Y avec les valeurs passées en paramètre
        X = x;
        Y = y;
    }
}


