namespace Algorithms;
using System;

public class ExercicesS1
{
    public static int Add(int a, int b){
        return a + b;
    }

    public static void Main1(string[] args)
    {
        Question1(34);
        Question2(5);
        Question3();
        Question4(5);
        Question5("7:31 PM");
        Question6A(90);
        Question6B(32.2);
        Question7();
        Question8(7);
        Question9(5);
        Question10("civic");
        Question11("Question 11");
        // Question12("");
        Question13();
        // Question14("marcd");

    }

    // Question 1 - Nombre pair/impair
    public static void Question1(long num)
    {

        if (num % 2 == 1)
        {
            Console.WriteLine("Question 1- " + "impair");
        }
        else if (num >= 0 && num <= 20)
        {
            Console.WriteLine("Question 1- " + "petit nombre pair");
        }
        else if (num > 20 && num <= 100)
        {
            Console.WriteLine("Question 1- " + "grand nombre pair");
        }
        else if (num > 100)
        {
            Console.WriteLine("Question 1- " + "impossiblement grand nombre");
        }
        else if (num < 0 && num % 2 == 0)
        {
            Console.WriteLine("Question 1- " + "nombre pair et négatif");
        }
        else if (num < 0)
        {
            Console.WriteLine("Question 1- " + "nombre impair et négatif");
        }
    }


    // Question 2 - Carré parfait
    public static void Question2(int num)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine("Question 2- " + "Le nombre est un carré parfait");
        }
        else
        {
            Console.WriteLine("Question 2- " + "Le nombre n'est pas un carré parfait");
        }
    }


    // Question 3 - Multiple de 3 et 5
    public static void Question3()
    {
        int count = 0;
        int nombre = 5;

        Console.WriteLine("Question 3- ");

        while (count < 10)
        {
            if (nombre % 5 == 0 && nombre % 3 == 0)
            {
                Console.WriteLine(nombre);
                count++;
            }
            nombre += 5; // Passer au prochain multiple de 5
        }
    }


    // Question 4 - Nombre laid
    public static void Question4(int num)
    {
        if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0)
        {
            Console.WriteLine("Question 4- " + "Le nombre est laid");
        }
        else
        {
            Console.WriteLine("Question 4- " + "Le nombre n'est pas laid");
        }
    }

    // Question 5 - Transformateur d’Heure
    public static void Question5(string heure)
    {
        try
        {
            DateTime heureAmericaine = DateTime.ParseExact(heure, "h:mm tt", null);
            string heureInternationale = heureAmericaine.ToString("HH:mm");
            Console.WriteLine("Question 5- " + "Heure au format international : " + heureInternationale);
        }
        catch (FormatException)
        {
            Console.WriteLine("Question 5- " + "Format d'heure incorrect (ex. 2:30 PM).");
        }
    }

    // Question 6 - Convertisseur de Température
    public static void Question6A(double temperatureF)
    {
        double temperatureC = (temperatureF - 32) * 5 / 9;
        Console.WriteLine("Question 6A- " + $"Température en Celsius : {temperatureC:f1} °C");
    }

    public static void Question6B(double temperatureC)
    {
        double temperatureF = (temperatureC * 9 / 5) + 32;
        Console.WriteLine("Question 6B- " + $"Température en Faranheit : {temperatureF:f1} °F");
    }

    // Question 7 - Suite de Fibonnaci
    public static void Question7()
    {
        long a = 0, b = 1, c;
        Console.WriteLine("Question 7- " + "Les 10 premiers nombres de Fibonacci :");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(a);
            c = a + b;
            a = b;
            b = c;
        }
    }

    // Question 8 - Fizz Buzz
    public static void Question8(long num)
    {
        if (num % 5 == 0 && num % 3 == 0)
        {
            Console.WriteLine("Question 8- " + "FizzBuzz");
        }
        else if (num % 3 == 0)
        {
            Console.WriteLine("Question 8- " + "Fizz");
        }
        else if (num % 5 == 0)
        {
            Console.WriteLine("Question 8- " + "Buzz");
        }
        else
        {
            Console.WriteLine($"Question 8- {num}");
        }
    }


    // Question 9 - Escalier
    public static void Question9(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            string escalier = new string('╦', i);
            Console.WriteLine(escalier.PadLeft(n));
        }
    }

    // Question 10 - Palindrome
    public static void Question10(string mot)
    {
        int longueur = mot.Length;
        bool estPalindrome = true;

        for (int i = 0; i < longueur / 2; i++)
        {
            if (mot[i] != mot[longueur - 1 - i])
            {
                estPalindrome = false;
                break;
            }
        }

        if (estPalindrome)
        {
            Console.WriteLine("Question 10- " + $"{mot} est un palindrome.");
        }
        else
        {
            Console.WriteLine("Question 10- " + $"{mot} n'est pas un palindrome.");
        }
    }

    // Question 11 - Texte dans un cadre de #
    public static void Question11(string texte)
    {
        int longueurTexte = texte.Length;
        int largeurCarre = longueurTexte + 4;

        Console.WriteLine(new string('#', largeurCarre));

        Console.Write("# ");
        foreach (char c in texte)
        {
            Console.Write(c);
        }
        Console.WriteLine(" #");

        Console.WriteLine(new string('#', largeurCarre));
    }

    /* Question 12 - Numérotation des titres
    public static string Question12(string header)
    {
        int idx = header.IndexOf(".");
        return header.Substring(idx + 1);
    }

    public static void MainExampleOfRemoveTitle(string[] args){
        Console.WriteLine(RemoveTitle("4.56.2")); // "56.2"
        Console.WriteLine(RemoveTitle("4.b.ii")); // "b.ii"
        Console.WriteLine(RemoveTitle("")); // ""
        Console.WriteLine(RemoveTitle("4.b")); // "b"
    }

*/

    // Question 13 - Didier au gym
    public static void Question13()
    {
        int premier5000MetresTempsMinutes = 22;
        int premier5000MetresTempsSecondes = 5;
        double premier5000MetresTempsTotal = premier5000MetresTempsMinutes + (premier5000MetresTempsSecondes / 60.0);
        double vitessePremier5000Metres = 3000.0 / premier5000MetresTempsTotal;

        int totalMetres = 6811;
        int tempsMinutes = 30;
        double tempsTotal = tempsMinutes + ((totalMetres - 5000) / vitessePremier5000Metres);
        double vitesseMoyenne = totalMetres / tempsTotal;

        Console.WriteLine("Question 13- " + $"Vitesse pour les premiers 5000 mètres : {vitessePremier5000Metres:F2} m/s");
        Console.WriteLine("Question 13- " + $"Vitesse moyenne pour les 30 minutes : {vitesseMoyenne:F2} m/s");

        if (vitesseMoyenne > vitessePremier5000Metres)
        {
            Console.WriteLine("Question 13- " + "Bravo!");
        }
    }

}
    /* Question 14 - Imprimer tous les dossiers du PATH
 public static void Question14(string path)
    {
        string[] subs = path.Split(':');

        foreach (var sub in subs)
        {
            Console.WriteLine(sub);
        }
    }

    public static void MainExampleOfPrintEachDirectoryOnPath(String[] args){
        string? path = Environment.GetEnvironmentVariable("PATH");
        Question14(path ?? "");
    }

*/




