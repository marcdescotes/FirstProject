using System;
using Algorithms;
namespace Algorithms.Q4_MonteCarlo;

public class Square
{
    // Propriété pour la longueur du côté du carré
    public double Cote { get; private set; }

    // Constructeur de la classe Square prenant la longueur du côté comme paramètre
    public Square(double cote)
    {
        // Vérifier si la longueur du côté est négative. Si c'est le cas, une exception est lancé.
        if (cote < 0)
        {
            throw new ArgumentException("La longueur du côté ne peut pas être négative.");
        }

        // Initialisation de la propriété Cote avec la valeur passée en paramètre
        Cote = cote;
    }

    // Vérifier si un point donné est à l'intérieur du carré
    public bool IsIn(Point point)
    {
        // Vérifier si le point est à l'intérieur du carré en comparant les coordonnées du point avec la moitié de la longueur du côté
        double halfCote = Cote / 2;
        double absX = Math.Abs(point.X);
        double absY = Math.Abs(point.Y);

        return absX <= halfCote && absY <= halfCote;
    }


    // Générer un point aléatoire à l'intérieur du carré en utilisant un générateur de nombres aléatoires
    public Point RandomPoint(Random random)
    {
        // Calcul de la moitié de la longueur du côté
        double halfCote = Cote / 2;

        // Génération de coordonnées X et Y aléatoires à l'intérieur du carré
        double randomX = (random.NextDouble() * Cote) - halfCote;
        double randomY = (random.NextDouble() * Cote) - halfCote;

        // Création et retour d'un nouveau point représentant les coordonnées aléatoires
        return new Point(randomX, randomY);
    }
}


