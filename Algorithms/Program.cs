namespace Algorithms;

using Algorithms.Q3_TicTacToe;
public class EntryPoint
{
    public static void Main(string[] args)
    {

// Question 3
        TicTacToe game = new TicTacToe();

// Simuler une partie où X gagne
        game.XPlay(0, 0);
        game.OPlay(1, 0);
        game.XPlay(0, 1);
        game.OPlay(1, 1);
        game.XPlay(0, 2);

GameState gameState = game.GetGameState();
if (gameState == GameState.XWins)
{
    Console.WriteLine("X gagne la partie!");
}
else if (gameState == GameState.OWins)
{
    Console.WriteLine("O gagne la partie!");
}
else if (gameState == GameState.Draw)
{
    Console.WriteLine("La partie est nulle!");
}
else
{
    Console.WriteLine("La partie est incomplète.");
}



    // Question 4
    int[] numberOfPoints = { 9999999 };

    foreach (int n in numberOfPoints)
    {
        double piEstimation = Monte_Carlo.PiEstimate(n);
        Console.WriteLine($"Estimation de Pi avec {n} points : {piEstimation}");
    }

    Console.ReadKey();

    }
}
