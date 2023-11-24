using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint5.Task4.V9.Lib;

namespace Tyuiu.KondrakovAA.Sprint5.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            Assert.AreEqual(7.57, resp.LoadFromDataFile(@"C:\DataSprint\InPutDataFileTask4V9.txt"));
        }
    }
}
