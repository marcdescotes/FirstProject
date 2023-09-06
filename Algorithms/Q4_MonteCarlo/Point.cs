namespace Algorithms;
using System;
using System.Globalization;

// Définition de la classe Point
public class Point
{
    // Déclaration de variables privées pour les coordonnées x et y du point
    private double x;
    private double y;

    // Constructeur de la classe Point prenant les coordonnées x et y comme paramètres
    public Point(double x, double y)
    {
        // Initialise les variables x et y avec les valeurs passées en paramètre
        this.x = x;
        this.y = y;
    }

    // Obtenir la valeur de la coordonnée x
    public double X()
    {
        return x;
    }

    // Obtenir la valeur de la coordonnée y
    public double Y()
    {
        return y;
    }

    // Calculer la distance du point à l'origine (0, 0)
    public double Distance()
    {
        // Calculer la distance
        return Math.Sqrt(X() * X() + Y() * Y());
    }

    // Calculer la distance entre ce point et un autre point donné
    public double Distance(Point other)
    {
        // Calcul des différences entre les coordonnées x et y des deux points
        double xDiff = X() - other.X();
        double yDiff = Y() - other.Y();

        // Calculer la distance entre les deux points
        return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
    }

    // Trouver le point médian entre ce point et un autre point donné.
    public Point MidPointOf(Point other)
    {
        // Calcul des coordonnées x et y du point médian
        double midX = (X() + other.X()) / 2;
        double midY = (Y() + other.Y()) / 2;

        // Création et retour d'un nouveau point représentant le point médian
        return new Point(midX, midY);
    }

    // Convertir le point en une chaîne de caractères JSON.
    public override string ToString()
    {
        // Utilisation de la classe CultureInfo.InvariantCulture pour garantir la cohérence de la représentation décimale
        return "{\"x\": " + this.x.ToString(CultureInfo.InvariantCulture) + ", \"y\": " + this.y.ToString(CultureInfo.InvariantCulture) + "}";
    }
}
