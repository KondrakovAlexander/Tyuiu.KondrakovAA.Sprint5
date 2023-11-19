using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint5.Task2.V15.Lib;

namespace Tyuiu.KondrakovAA.Sprint5.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            int[,] matrix = new int[,] { { 6, 1, 7 }, { 1, 8, 5 }, { 6, 6, 4 } };
            Assert.AreEqual("6; 0; 0; \n0; 8; 0; \n6; 6; 4; \n", resp.SaveToFileTextData(matrix));
        }
    }
}
