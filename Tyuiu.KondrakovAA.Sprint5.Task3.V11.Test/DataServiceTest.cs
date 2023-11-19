using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint5.Task3.V11.Lib;

namespace Tyuiu.KondrakovAA.Sprint5.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            Assert.AreEqual(-2.556, resp.SaveToFileTextData(3));
        }
    }
}
