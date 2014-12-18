using Matrix;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace TestMatrix
{
    [TestClass]
    public class TestMatrix
    {
        [TestMethod]
        public void TestFindNextEmptyCell()
        {

            int[,] oneByOneMatrix = { { 1, 2 }, { 3, 4 } };
            int x = 0;
            int y = 0;

            var result = Matrix.WalkInMatrix.FindNextEmptyCell(oneByOneMatrix, x, y);
            Assert.IsFalse(result, "Method found empty cells!");
        }
    }
}
