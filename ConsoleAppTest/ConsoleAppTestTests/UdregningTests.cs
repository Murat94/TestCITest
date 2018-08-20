using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest.Tests
{
    [TestClass()]
    public class UdregningTests
    {
        [TestMethod()]
        public void addTest()
        {
            Udregning udregning = new Udregning();

            int expected = udregning.add(5, 5);

            Assert.AreEqual(10, expected);
        }
    }
}