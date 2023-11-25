using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint5.Task7.V9.Lib;

namespace Tyuiu.KondrakovAA.Sprint5.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            Assert.AreEqual("ello, Мир! Это s y irst rogram.", resp.LoadDataAndSave(""));
        }
    }
}
