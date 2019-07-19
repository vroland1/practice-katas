using DuplicateEncode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DuplicateEncodeTest
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
        public void DuplicateEncode()
        {
            Assert.AreEqual("(((", kata.DuplicateEncode("din"));
            Assert.AreEqual("()()()", kata.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", kata.DuplicateEncode("Success"));
            Assert.AreEqual("))((", kata.DuplicateEncode("(( @"));
        }
    }
}
