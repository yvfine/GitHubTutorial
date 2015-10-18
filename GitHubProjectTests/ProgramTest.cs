using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GitHubTestProject;

namespace GitHubProjectTests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestIsPrime()
        {
            Assert.IsTrue(Program.IsPrime(2));
            Assert.IsTrue(Program.IsPrime(3));
            Assert.IsTrue(Program.IsPrime(7));
            Assert.IsTrue(Program.IsPrime(211));
            Assert.IsTrue(Program.IsPrime(44893));
            Assert.IsFalse(Program.IsPrime(6));
            Assert.IsFalse(Program.IsPrime(72));
            Assert.IsFalse(Program.IsPrime(159));
            Assert.IsFalse(Program.IsPrime(77789));
        }

        [TestMethod]
        public void TestSort()
        {
            int[] a = new int[] { 8, 2, 58, 34, 153, 4 };
            int[] b = new int[] { 2, 4, 8, 34, 58, 153 };
            Program.Sort(a);
            Assert.IsTrue(a.SequenceEqual(b));
        }

        [TestMethod]
        public void TestCountVectors()
        {
            Assert.AreEqual(Program.CountVectors(4), 13);
            Assert.AreEqual(Program.CountVectors(8), 149);
            Assert.AreEqual(Program.CountVectors(13), 3136);
        }
    }
}
