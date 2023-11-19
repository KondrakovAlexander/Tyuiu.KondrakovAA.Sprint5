using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint5.Task1.V6.Lib;

namespace Tyuiu.KondrakovAA.Sprint5.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            Assert.AreEqual("4,67 0,43 -8,26 -9,87 -3,98 1 0,02 -1,87 3,74 16,43", resp.SaveToFileTextData(-5,5));
        }
    }
}
