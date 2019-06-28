using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeGameLib;

namespace TicTacToeGameTest
{
    [TestClass]
    public class CellTest
    {
        [TestMethod]
        public void CellShouldBeEmpty()
        {
            Cell cell = new Cell();
            // Assert.IsFalse(c.Equals(null));
            var result = cell.GetMark();
            Assert.AreEqual(result, Mark.EMPTY);

        }
        [TestMethod]
        public void CellMarkedX()
        {
            Cell cell = new Cell();
            cell.SetMark(Mark.X);
            var result = cell.GetMark();
            Assert.AreEqual(result,Mark.X);

        }

        [TestMethod]
        public void CellMarkedO()
        {
            Cell cell = new Cell();
            cell.SetMark(Mark.O);
            var result = cell.GetMark();
            Assert.AreEqual(result, Mark.O);

        }
    }
}
