using EnoughIsEnough;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnoughIsEnoughTest
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
        public void TestSimple()
        {
            var expected = new int[] { 20, 37, 21 };

            var actual = kata.EnoughIsEnough(new int[] { 20, 37, 20, 21 }, 1);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSimple2()
        {
            var expected = new int[] { 1, 1, 3, 3, 7, 2, 2, 2 };

            var actual = kata.EnoughIsEnough(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
