using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint5.Task6.V19.Lib;

namespace Tyuiu.KondrakovAA.Sprint5.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            Assert.AreEqual(3, resp.LoadFromDataFile(@"C:\DataSprint5\InPutDataFileTask6V19.txt"));
        }
    }
}
