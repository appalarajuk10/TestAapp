using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstAppVS2015;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppVS2015.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void WriteNameTest()
        {
            string name = "Raju";
            Assert.AreEqual("Raju", name);
        }

        [TestMethod()]
        public void combineArrayStringWithSpaceTest()
        {

            Program target = new Program(); // TODO: Initialize to an appropriate value
            string[] stringArray = new string[] { "Today", "is", "the", "wonderful", "day", "of", "my", "life" }; // TODO: Initialize to an appropriate value
            string expectedResult = "Today is the wonderful day of my life"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.combineArrayStringWithSpace(stringArray);
            Assert.AreEqual(expectedResult, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");

        }
    }
}