using FindOddInt;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindOddIntTest
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
        public void findIt()
        {
            Assert.AreEqual(4, kata.findIt(new int[] { 4, 6, 4, 9, 6, 9, 4 }));
            Assert.AreEqual(27, kata.findIt(new int[] { 27, 27, 27, 27, 49, 27, 49 }));
            Assert.AreEqual(1, kata.findIt(new int[] { 1, 13, 16, 13, 16 }));
        }
    }
}
