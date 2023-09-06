using System;
using System.Text;

namespace Algorithms
{
    public class Q2_Ascii
    {
        public static string CreateStaircase(int height, int width)
        {
            // Vérifie si la hauteur ou la largeur est inférieure ou égale à zéro.
            if (height <= 0 || width <= 0)
            {
                return ""; // Si l'une des dimensions est invalide, retourne une chaîne vide.
            }

            if (width < 0)
            {
                width = Math.Abs(width); // Vérifie si la largeur est négative. La rend positive si c'est le cas.
            }

            // Initialise un objet StringBuilder pour construire la représentation de l'escalier Ascii.
            StringBuilder staircase = new StringBuilder();

            // Boucle externe pour itérer à travers chaque palier de l'escalier en hauteur.
            for (int i = 1; i <= height; i++)
            {
                // Boucle intermédiaire pour itérer à travers chaque ligne du palier en largeur.
                for (int j = 0; j < width; j++)
                {
                    // Boucle la plus interne pour ajouter le nombre de '#' à la ligne.
                    for (int k = 0; k < i * width; k++)
                    {
                        // Ajoute le caractère '#' à chaque étape de l'escalier.
                        staircase.Append("#");
                    }
                    // Ajoute une nouvelle ligne à la fin de chaque ligne du palier.
                    staircase.AppendLine();
                }
            }

            // Convertit le contenu du StringBuilder en une chaîne de caractères et la retourne.
            return staircase.ToString();
        }

        public static void Main_Ascii(string[] args)
        {
            // Hauteur et largeur de l'escalier pour le test.
            int height = 5;
            int width = 2;

            string result = CreateStaircase(height, width);

            Console.WriteLine(result);
        }
    }
}

