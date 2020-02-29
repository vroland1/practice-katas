using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhoLikesIt;

namespace WhoLikesItTest
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
            Assert.AreEqual("no one likes this", kata.WhoLikesIt(new string[0]));
            Assert.AreEqual("Peter likes this", kata.WhoLikesIt(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", kata.WhoLikesIt(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", kata.WhoLikesIt(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", kata.WhoLikesIt(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
    }
}
