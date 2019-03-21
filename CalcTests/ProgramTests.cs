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
        public void sumTest()
        {
            Program calc = new Program();
            Assert.AreEqual(4, calc.sum(1, 3));
        }
    }
}