using MoveZeroes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoveZeroesTest
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
        public void MoveZeroes()
        {
            CollectionAssert.AreEqual(new int[] { 2, 3, 5, 0, 0, 0}, kata.MoveZeroes(new int[] { 0, 2, 0, 0, 3, 5 }));
            CollectionAssert.AreEqual(new int[] { 1, -5, 34, 7, 0, 0 }, kata.MoveZeroes(new int[] { 0, 0, 1, -5, 34, 7 }));
            CollectionAssert.AreEqual(new int[] { 11, 24, 47, 0 }, kata.MoveZeroes(new int[] { 11, 0, 24, 47 }));
        }
    }
}
