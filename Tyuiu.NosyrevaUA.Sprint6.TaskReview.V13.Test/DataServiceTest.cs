using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint6.TaskReview.V13.Lib;

namespace Tyuiu.NosyrevaUA.Sprint6.TaskReview.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            int[,] matrix = { { 1, 2, 3, 45, 5, 2 }, { 23, 42, 2, 5, 3, -2 }, { 1, 3, 23, -67, 0, -5 }, { 1, 3, 2, 4, 5, 6 }, { 1, 2, 3, 4, 5, 76 } };  // N = 4 на M = 5 (5 на 6)

            int C = 2;                                //считать с 3 столбца

            int K = 2;                                //с 3 по 5 строки
            int L = 5;

            DataService ds = new DataService();
            int res = ds.GetMatrix(matrix, C, K, L);

            int w = 26;
            Assert.AreEqual(w, res);
        }   
    }
}
