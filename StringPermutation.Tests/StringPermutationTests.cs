using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib = StringPermutation.Libraries.StringPermutation;

namespace StringPermutation.Tests
{
    [TestClass]
    public class StringPermutationTests
    {
        [DataTestMethod]
        [DataRow("abc", 6)]
        [DataRow("potato", 24)]
        [DataRow("houck", 120)]
        [DataRow("Thomas", 720)]
        [DataRow("abcdefghijklmnopqrstuv", 85357272)]
        public void StringPermutationTest(string permutationString, int expectedCount)
        {
            var perm = new Lib.StringPermutation(permutationString);
            Assert.AreEqual(expectedCount, perm.Permutations.Count);
        }
    }
}
