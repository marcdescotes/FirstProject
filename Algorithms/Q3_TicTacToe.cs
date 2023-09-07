namespace Algorithms.Q3_TicTacToe;
using System;


// Définition de deux énumérations : Player et SquareState
public enum Player
{
    X,
    O
}

public enum SquareState
{
    Empty,
    X,
    O
}

public enum GameState
{
    Incomplete,
    XWins,
    OWins,
    Draw
}

public class TicTacToe
{
    // Déclaration des membres de la classe
    private SquareState[,] board;  // Le plateau de jeu
    private Player currentPlayer;   // Le joueur actuel (X commence par défaut)

    public TicTacToe()
    {
        // Constructeur de la classe TicTacToe
        board = new SquareState[3, 3];  // Crée un tableau 3x3 pour le plateau de jeu
        currentPlayer = Player.X;  // Le joueur X commence par défaut
        InitializeBoard();  // Initialise le plateau avec des cases vides
    }

    private void InitializeBoard()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                board[row, col] = SquareState.Empty;
            }
        }
    }

    public void XPlay(int row, int col)
    {
        // Méthode pour que le joueur X joue
        if (board[row, col] == SquareState.Empty && currentPlayer == Player.X)
        {
            // Vérifie si la case est vide et si c'est au tour du joueur X
            board[row, col] = SquareState.X;  // Marque la case avec un X
            currentPlayer = Player.O;  // Passe au joueur O
        }
    }

    public void OPlay(int row, int col)
    {
        // Méthode pour que le joueur O joue
        if (board[row, col] == SquareState.Empty && currentPlayer == Player.O)
        {
            // Vérifie si la case est vide et si c'est au tour du joueur O
            board[row, col] = SquareState.O;  // Marque la case avec un O
            currentPlayer = Player.X;  // Passe au joueur X
        }
    }

    public Player NextPlayer()
    {
        // Méthode pour obtenir le prochain joueur à jouer
        return currentPlayer;
    }

     public GameState GetGameState()
    {
        // Vérification des lignes
        for (int row = 0; row < 3; row++)
        {
            if (board[row, 0] != SquareState.Empty && board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
            {
                return board[row, 0] == SquareState.X ? GameState.XWins : GameState.OWins;
            }
        }
        // Vérification des colonnes
        for (int col = 0; col < 3; col++)
        {
            if (board[0, col] != SquareState.Empty && board[0, col] == board[1, col] && board[1, col] == board[2, col])
            {
                return board[0, col] == SquareState.X ? GameState.XWins : GameState.OWins;
            }
        }
        // Vérification des diagonales
        if (board[0, 0] != SquareState.Empty && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
        {
            return board[0, 0] == SquareState.X ? GameState.XWins : GameState.OWins;
        }
        if (board[0, 2] != SquareState.Empty && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
        {
            return board[0, 2] == SquareState.X ? GameState.XWins : GameState.OWins;
        }

        if (IsBoardFull())
        {
            return GameState.Draw;
        }

        return GameState.Incomplete;
    }

    private bool IsBoardFull()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                if (board[row, col] == SquareState.Empty)
                {
                    return false; // Il y a au moins une case vide
                }
            }
        }
        return true; // Aucune case vide
    }
}



