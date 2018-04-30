using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeadAnts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadAnts;

namespace DeadAnts.Tests
{
    [TestClass]
    public class kataTests
    {
        [TestMethod()]
        public void DeadAntCountTest()
        {
            var test = new kata();
            var input = "ant ant ant ant";
            var actural = test.DeadAntCount(input);
            var expect = 0;
            Assert.AreEqual(expect, actural);
        }
        [TestMethod()]
        public void DeadAntCountTest2()
        {
            var test = new kata();
            var actural = test.DeadAntCount(null);
            var expect = 0;
            Assert.AreEqual(expect, actural);
        }
        [TestMethod()]
        public void DeadAntCountTest3()
        {
            var test = new kata();
            var input = "ant anantt aantnt";
            var actural = test.DeadAntCount(input);
            var expect = 2;
            Assert.AreEqual(expect, actural);
        }
        [TestMethod()]
        public void DeadAntCountTest4()
        {
            var test = new kata();
            var input = "ant ant .... a nt";
            var actural = test.DeadAntCount(input);
            var expect = 1;
            Assert.AreEqual(expect, actural);
        }
    }
}