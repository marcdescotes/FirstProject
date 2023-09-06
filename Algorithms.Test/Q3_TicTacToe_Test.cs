// namespace Algorithms.Test;
// using Algorithms;

// [TestClass]
// public class Q3_TicTacToe_Test
// {

//     [TestMethod]
//     public void TestXWins()
//     {
//         TicTacToe game = new TicTacToe();

//         game.XPlay(0, 0);
//         game.OPlay(1, 0);
//         game.XPlay(0, 1);
//         game.OPlay(1, 1);
//         game.XPlay(0, 2);

//         Player winner = game.TheWinnerIs();

//         Assert.AreEqual(Player.X, winner);
//     }

//     [TestMethod]
//     public void TestOWins()
//     {
//         TicTacToe game = new TicTacToe();

//         game.XPlay(0, 0);
//         game.OPlay(1, 0);
//         game.XPlay(0, 1);
//         game.OPlay(1, 1);
//         game.XPlay(2, 0);
//         game.OPlay(1, 2);

//         Player winner = game.TheWinnerIs();

//         Assert.AreEqual(Player.O, winner);
//     }
// }

