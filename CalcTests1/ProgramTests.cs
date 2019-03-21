using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void ConvertToKelvinTest()
        {
            Assert.AreEqual(283, Program.ConvertToKelvin(10));
       //     Assert.AreEqual(100, Program.ConvertToKelvin(15));
        }

        [TestMethod()]
        public void ConvertToFahrenheitTest()
        {
            Assert.AreEqual(50, Program.ConvertToFahrenheit(10));
        }

    }
}