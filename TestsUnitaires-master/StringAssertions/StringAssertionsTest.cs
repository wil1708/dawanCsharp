using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace StringAssertions
{
    [TestClass]
    public class StringAssertionsTest
    {
        [TestMethod]
        [TestCategory("Classe StringAssertion")]
        public void StartWith_Test()
        {
            StringAssert.StartsWith("chaine de test", "chaine");
        }

        [TestMethod]
        [TestCategory("Classe StringAssertion")]
        public void EndWith_Test()
        {
            StringAssert.EndsWith("chaine de test", "Test");
        }

        [TestMethod]
        [TestCategory("Classe StringAssertion")]
        public void Contains_Test()
        {
            StringAssert.Contains("chaine de test", "De");
        }

        [TestMethod]
        [TestCategory("Classe StringAssertion")]
        public void Match_Test()
        {
            Regex regEmail = new Regex(@"^[a-zA-Z0-9\-]{1,30}@[a-zA-Z0-9]{1,30}\.[a-z-A-Z]{2,3}$");
            StringAssert.Matches("test@dawanfr", regEmail);
        }
    }
}
/*
 * TDD : Test Driver Developement - Dev guidé par les tests
 * 
 */
