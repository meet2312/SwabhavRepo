using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeGameLib;

namespace TicTacToeGameTest
{
    [TestClass]
    public class ResultAnalyserTest
    {
        [TestMethod]
        public void GotSameMarkInHorizontal_Result_IsWin()
        {
            Board board = new Board();
            ResultAnalyzer result = new ResultAnalyzer(board);
            board.SetLocation(Mark.O, 0);
            board.SetLocation(Mark.X, 1);
            board.SetLocation(Mark.O, 2);
            board.SetLocation(Mark.O, 3);
            board.SetLocation(Mark.O, 4);
            board.SetLocation(Mark.O, 5);
            board.SetLocation(Mark.X, 6);
            board.SetLocation(Mark.O, 7);
            board.SetLocation(Mark.X, 8);

            Assert.AreEqual(Result.WIN, result.AnalyzeResult());

        }

        [TestMethod]
        public void GotDifferentMarkInHorizontal_Result_is_Going_on()
        {
            Board board = new Board();
            ResultAnalyzer result = new ResultAnalyzer(board);
            board.SetLocation(Mark.X, 0);
            board.SetLocation(Mark.O, 1);
            board.SetLocation(Mark.X, 2);
            Assert.AreEqual(Result.ONGOING, result.AnalyzeResult());

        }

        [TestMethod]
        public void GotMark_Empty_InHorizontal_Result_Is_In_Progress()
        {
            Board board = new Board();
            ResultAnalyzer result = new ResultAnalyzer(board);
            board.SetLocation(Mark.O, 6);
            board.SetLocation(Mark.EMPTY, 7);
            board.SetLocation(Mark.O, 8);
            Assert.AreEqual(Result.ONGOING, result.AnalyzeResult());

        }

        [TestMethod]
        public void If_Board_is_Full_Result_is_Draw()
        {
            Board board = new Board();
            ResultAnalyzer result = new ResultAnalyzer(board);
            board.SetLocation(Mark.X, 0);
            board.SetLocation(Mark.O, 1);
            board.SetLocation(Mark.X, 2);
            board.SetLocation(Mark.O, 3);
            board.SetLocation(Mark.X, 4);
            board.SetLocation(Mark.O, 5);
            board.SetLocation(Mark.O, 6);
            board.SetLocation(Mark.X, 7);
            board.SetLocation(Mark.O, 8);
            Assert.AreEqual(Result.DRAW, result.AnalyzeResult());

        }

        [TestMethod]
        public void If_Board_is_Full_With_Win()
        {
            Board board = new Board();
            ResultAnalyzer result = new ResultAnalyzer(board);
            board.SetLocation(Mark.X, 0);
            board.SetLocation(Mark.X, 1);
            board.SetLocation(Mark.X, 2);
            board.SetLocation(Mark.O, 3);
            board.SetLocation(Mark.X, 4);
            board.SetLocation(Mark.O, 5);
            board.SetLocation(Mark.O, 6);
            board.SetLocation(Mark.X, 7);
            board.SetLocation(Mark.O, 8);
            Assert.AreEqual(Result.WIN, result.AnalyzeResult());

        }

        [TestMethod]
        public void GotSameMarkInVertical_Result_IsWin()
        {
            Board board = new Board();
            ResultAnalyzer result = new ResultAnalyzer(board);
            board.SetLocation(Mark.X, 2);
            board.SetLocation(Mark.O, 5);
            board.SetLocation(Mark.X, 8);
            board.SetLocation(Mark.O, 1);
            board.SetLocation(Mark.O, 4);
            board.SetLocation(Mark.X, 3);
            board.SetLocation(Mark.O, 7);


            Assert.AreEqual(Result.WIN, result.AnalyzeResult());

        }


        [TestMethod]
        public void GotDifferentMarkInVertical_Result_is_Going_on()
        {
            Board board = new Board();
            ResultAnalyzer result = new ResultAnalyzer(board);
            board.SetLocation(Mark.X, 1);
            board.SetLocation(Mark.O, 4);
            board.SetLocation(Mark.X, 7);
            Assert.AreEqual(Result.ONGOING, result.AnalyzeResult());

        }


        [TestMethod]
        public void GotMark_Empty_InVertical_Result_Is_In_Progress()
        {
            Board board = new Board();
            ResultAnalyzer result = new ResultAnalyzer(board);
            board.SetLocation(Mark.X, 1);
            board.SetLocation(Mark.EMPTY, 4);
            board.SetLocation(Mark.X, 7);
            Assert.AreEqual(Result.ONGOING, result.AnalyzeResult());

        }

        [TestMethod]
        public void GotSameMarkIn_Diagonal_Result_IsWin()
        {
            Board board = new Board();
            ResultAnalyzer result = new ResultAnalyzer(board);
            board.SetLocation(Mark.O, 2);
            board.SetLocation(Mark.O, 4);
            board.SetLocation(Mark.O, 6);
            Assert.AreEqual(Result.WIN, result.AnalyzeResult());

        }


    }
}
