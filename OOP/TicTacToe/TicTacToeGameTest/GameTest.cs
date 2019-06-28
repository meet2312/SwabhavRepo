using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeGameLib;

namespace TicTacToeGameTest
{
    [TestClass]
    public class GameTest
    {
        private static Game game;
        [TestMethod]
        public void Starting_The_Game_And_Wins()
        {
            game = new Game();
            game.Play(0);
            game.Play(1);
            game.Play(2);
            game.Play(3);
            game.Play(4);
            game.Play(5);
            game.Play(6);
            game.Play(7);
            var res = game.Status;
            Assert.AreEqual(Result.WIN, res);

        }

        [TestMethod]
        public void Starting_The_Game_And_OnGoing()
        {
            game = new Game();
            game.Play(0);
            game.Play(1);
            game.Play(2);
            game.Play(3);
            game.Play(4);
            var res = game.Status;
            Assert.AreEqual(Result.ONGOING, res);

        }

        [TestMethod]
        public void Starting_The_Game_And_is_Draw()
        {
            game = new Game();
            game.Play(0);
            game.Play(1);
            game.Play(2);
            game.Play(4);
            game.Play(3);
            game.Play(6);
            game.Play(5);
            game.Play(8);
            game.Play(7);
            var res = game.Status;
            Assert.AreEqual(Result.DRAW, res);

        }

        [TestMethod]
        public void Starting_The_Game_And_getting_name()
        {
            game = new Game();
            game.Play(0);
            game.Play(1);
            game.Play(2);
            game.Play(4);
            game.Play(3);
            game.Play(6);
            game.Play(5);
            game.Play(8);
            game.Play(7);
            var res = game.Player.Name;
            Assert.AreEqual("meet", res);

        }

    }
}
