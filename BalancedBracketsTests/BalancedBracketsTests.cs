using BalancedBracketsNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void SingleLeftBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void SingleRightBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]
        public void UnevenNumberOfBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[]]]"));
        }

        [TestMethod]
        public void OppositeBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void StringWithNoBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("blah blah i'm a string"));
        }

        [TestMethod]
        public void StringWithBothBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("bla[h blah i'm a] string"));
        }

        [TestMethod]
        public void StringWithMultipleSetsOfNestedBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("bla[h bl[ah[ i'm ]a s]tring]"));
        }

        [TestMethod]
        public void StringWithOppositeBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("blah bla]h i'm[ a string"));
        }

        [TestMethod]
        public void StringWithFlipFlopBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[][blah b]lah i'm a string"));
        }

        [TestMethod]
        public void StringWithOneBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("blah b]lah i'm a string"));
        }
    }
}
