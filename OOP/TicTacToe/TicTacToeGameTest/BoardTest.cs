using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeGameLib;

namespace TicTacToeGameTest
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void BoardIsEmpty_GivesTrue()
        {
            Board board = new Board();
            Assert.AreEqual(true, board.IsBoardEmpty());
        }

        [TestMethod]
        public void Add_X_ToBoardAt_Specific_Index()
        {
            Board board = new Board();
            Mark mark = Mark.X;
            int index = 3;
            board.SetLocation(mark, index);
            Cell[] cell = board.GetCells();
            Assert.AreEqual(Mark.X, cell[3].GetMark());

        }

        [TestMethod]
        public void Add_O_ToBoardAt_Specific_Index()
        {
            Board board = new Board();
            Mark mark = Mark.O;
            int index = 1;
            board.SetLocation(mark, index);
            Cell[] cell = board.GetCells();
            Assert.AreEqual(Mark.O, cell[1].GetMark());

        }

        [TestMethod]
        public void BoardIsFull_IsTrue()
        {
            Board board = new Board();
            for(int index=0;index<=8;index++)
            {
                board.SetLocation(Mark.O, index);

            }
            Assert.AreEqual(true, board.IsBoardFull());
        }

        [TestMethod]
        public void Adding_O_ToBoard_AtSameIndex_DontAdd()
        {
            try
            {
                Board board = new Board();
                int index = 2;
                board.SetLocation(Mark.O, index);
                board.SetLocation(Mark.X, index);
                Assert.Fail();
            }
           catch(Exception e)
            {
                Assert.IsTrue(e is Exception);

            }

        }

    }
}
