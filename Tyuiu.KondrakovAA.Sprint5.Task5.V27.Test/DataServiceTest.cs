using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint5.Task5.V27.Lib;

namespace Tyuiu.KondrakovAA.Sprint5.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService resp = new DataService();
            Assert.AreEqual(7.5, resp.LoadFromDataFile(@"C:\DataSprint5\InPutDataFileTask5V27.txt"));

        }
    }
}
