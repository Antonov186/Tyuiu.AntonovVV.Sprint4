﻿using Tyuiu.AntonovVV.Sprint4.Task7.V3.Lib;
namespace Tyuiu.AntonovVV.Sprint4.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string text = "27182818";
            int n = 4;
            int m = 2;
            int res = ds.Calculate(n, m, text);

            Assert.AreEqual(3, res);
        }
    }
}