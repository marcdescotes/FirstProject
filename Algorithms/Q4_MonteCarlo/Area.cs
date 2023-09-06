using System;
namespace Algorithms.Q4_MonteCarlo;

public class Area
{
    public static double CalculateArea(Square square)
    {
        if (square == null)
        {
            throw new ArgumentNullException("Le carré ne peut pas être null.");
        }
        return Math.Pow(square.Cote, 2);
    }
}