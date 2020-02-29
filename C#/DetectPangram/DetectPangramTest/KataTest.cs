using DetectPangram;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DetectPangramTest
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
            Assert.IsTrue(kata.DetectPangram("The quick brown fox jumps over the lazy dog."));
            Assert.IsFalse(kata.DetectPangram("This sentence is not a pangram."));
        }
    }}
