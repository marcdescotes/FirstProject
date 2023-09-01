namespace Algorithms;
using System;

public class Q3_TicTacToe
{

static void Main_TicTacToe(string[] args)
        {
            TicTacToe game = new TicTacToe();

            // Exemple de jeu
            game.XPlay(0, 0);
            game.OPlay(1, 0);
            game.XPlay(0, 1);
            game.OPlay(2, 0);   
            game.XPlay(0, 2);

            Player winner = game.TheWinnerIs();
            Console.WriteLine("Le joueur gagnant est : " + winner);
        }

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

    public class TicTacToe
    {
        private SquareState[,] board;
        private Player currentPlayer;

        public TicTacToe()
        {
            board = new SquareState[3, 3];
            currentPlayer = Player.X;
            InitializeBoard();
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
            if (board[row, col] == SquareState.Empty && currentPlayer == Player.X)
            {
                board[row, col] = SquareState.X;
                currentPlayer = Player.O;
            }
        }

        public void OPlay(int row, int col)
        {
            if (board[row, col] == SquareState.Empty && currentPlayer == Player.O)
            {
                board[row, col] = SquareState.O;
                currentPlayer = Player.X;
            }
        }

        public Player NextPlayer()
        {
            return currentPlayer;
        }

        public Player TheWinnerIs()
        {
            // Check rows
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] != SquareState.Empty && board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
                {
                    return board[row, 0] == SquareState.X ? Player.X : Player.O;
                }
            }

            // Check columns
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] != SquareState.Empty && board[0, col] == board[1, col] && board[1, col] == board[2, col])
                {
                    return board[0, col] == SquareState.X ? Player.X : Player.O;
                }
            }

            // Check diagonals
            if (board[0, 0] != SquareState.Empty && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return board[0, 0] == SquareState.X ? Player.X : Player.O;
            }

            if (board[0, 2] != SquareState.Empty && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return board[0, 2] == SquareState.X ? Player.X : Player.O;
            }

            return Player.X; // Default winner when no one has won yet
        }
    }
}
