using Coding_Interview_Algorithms_Data_Structures.Secao_3;
using Coding_Interview_Algorithms_Data_Structures.Secao_4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coding_Interview_Algorithms_Data_Structures
{
    [TestClass]
    public class DataStructuresTest
    {

        #region ReverseString

        [TestMethod]
        public void ReverseStringAreEqual()
        {
            ReverseString palavra = new ReverseString();

            var resultado1 = palavra.ReverseString1("apple");
            var resultado2 = palavra.ReverseString2("hello");
            var resultado3 = palavra.ReverseStringLoop("Greetings!");

            Assert.AreEqual("elppa", resultado1);
            Assert.AreEqual("olleh", resultado2);
            Assert.AreEqual("!sgniteerG", resultado3);
        }

        [TestMethod]
        public void ReverseStringAreNotEqual()
        {
            ReverseString palavra = new ReverseString();

            var resultado1 = palavra.ReverseString1("apples");
            var resultado2 = palavra.ReverseString2("hellos");
            var resultado3 = palavra.ReverseStringLoop("Greetings!s");

            Assert.AreNotEqual("elppa", resultado1);
            Assert.AreNotEqual("olleh", resultado2);
            Assert.AreNotEqual("!sgniteerG", resultado3);
        }

        #endregion

        #region Palindrome

        [TestMethod]
        public void PalindromeIsTrue()
        {
            Palindrome palindrome = new Palindrome();

            var result = palindrome.ValidatePalindrome("abba");
            var result2 = palindrome.ValidatePalindromeLoop("abba");

            Assert.IsTrue(result);
            Assert.IsTrue(result2);
        }

        [TestMethod]
        public void PalindromeIsFalse()
        {
            Palindrome palindrome = new Palindrome();

            var result = palindrome.ValidatePalindrome("abbas");
            var result2 = palindrome.ValidatePalindromeLoop("abbas");

            Assert.IsFalse(result);
            Assert.IsFalse(result2);
        }

        #endregion

    }
}
