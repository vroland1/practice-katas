using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrinterErrors;
using System;

namespace PrinterErrorsTest
{
    [TestClass]
    public class KataTest
    {
        Kata kata;

        [TestInitialize]
        public void Initialize()
        {
            kata = new Kata();
        }

        [TestMethod]
        public void PrinterErrors()
        {
            Console.WriteLine("Testing PrinterError");
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Assert.AreEqual("3/56", kata.PrinterError(s));
        }
    }
}
