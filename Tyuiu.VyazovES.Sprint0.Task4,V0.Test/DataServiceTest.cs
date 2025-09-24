using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VyazovES.Sprint0.Task4.V0.Lib;

namespace Tyuiu.VyazovES.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));


        }
    }
}
