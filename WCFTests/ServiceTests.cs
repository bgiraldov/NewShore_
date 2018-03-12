using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Tests
{
    [TestClass()]
    public class ServiceTests
    {
        [TestMethod()]
        public void EsClienteTest()
        {
            string expected = "TZEAVHLMOFOUEBYOPDRBAADILNGVDUEKWATZLOTTONTUT";
            string actual = "VOLOTEA";
            Assert.AreEqual(expected, actual);
        }
    }
}