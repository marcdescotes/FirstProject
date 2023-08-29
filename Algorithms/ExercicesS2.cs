namespace Algorithms;
using System;

public class ExercicesS2
{

    public static void Main_1(string[] args)
    {
        Console.WriteLine(TriangleExercice.BuildTriangle(5));
    }

    // Question 1 - Triangle d'étoiles
    public class TriangleExercice
    {
        public static string Repeat(string s, int n)
        {
            string ret = "";
            for (int i = 0; i < n; i++)
            {
                ret = ret + s;
            }
            return ret;
        }

        public static string BuildTriangle(int height)
        {
            string ret = "";
            for (int i = 0; i < height; i++)
            {
                int nbrStarts = 2 * i + 1;
                int nbrSpaces = height - (i + 1);
                string spaces = Repeat("_", nbrSpaces);
                string starts = Repeat("*", nbrStarts);
                ret += "" + spaces + starts + "\n";

            }
            return ret;
        }

    }
}

// Question 2 - Carte d'identification (fait dans dossier idCard)

// Question 3 - Liste chaîné d'entiers (dossier ChainLink)