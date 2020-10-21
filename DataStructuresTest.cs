using Coding_Interview_Algorithms_Data_Structures.Secao__8;
using Coding_Interview_Algorithms_Data_Structures.Secao_10;
using Coding_Interview_Algorithms_Data_Structures.Secao_3;
using Coding_Interview_Algorithms_Data_Structures.Secao_4;
using Coding_Interview_Algorithms_Data_Structures.Secao_5;
using Coding_Interview_Algorithms_Data_Structures.Secao_6;
using Coding_Interview_Algorithms_Data_Structures.Secao_7;
using Coding_Interview_Algorithms_Data_Structures.Secao_9;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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


        #region IntegerReversal

        [TestMethod]
        public void IntegerReversal()
        {
            IntegerReversal integerReversal = new IntegerReversal();

            int result = integerReversal.ReverseInteger(345);

            Assert.AreEqual(543, result);
        }

        [TestMethod]
        public void IntegerReversalNegativeNumber()
        {
            IntegerReversal integerReversal = new IntegerReversal();

            int result = integerReversal.ReverseInteger(-51);

            Assert.AreEqual(-15, result);
        }

        #endregion


        #region MaxChar

        [TestMethod]
        public void MaxChar()
        {
            MaxChar maxChar = new MaxChar();

            string key = "";
            int value = 0;

            var result = maxChar.ObterMaxChar("Hello There!");

            foreach (var item in result)
            {
                if (value < item.Value)
                {
                    key = item.Key.ToString();
                    value = item.Value;
                }                
            }

            Assert.AreEqual("e", key);
            Assert.AreEqual(3, value);
        }

        [TestMethod]
        public void MaxCharSegundoExemplo()
        {
            MaxChar maxChar = new MaxChar();

            string key = "";
            int value = 0;

            var result = maxChar.ObterMaxChar("apple 1231111");

            foreach (var item in result)
            {
                if (value < item.Value)
                {
                    key = item.Key.ToString();
                    value = item.Value;
                }
            }

            Assert.AreEqual("1", key);
            Assert.AreEqual(5, value);
        }

        #endregion


        #region FizzBuzz


        [TestMethod]
        public void ValidaFizzBuzzIsTrue()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            var result1 = fizzBuzz.GetFizzBuzz(3);
            var result2 = fizzBuzz.GetFizzBuzz(5);
            var result3 = fizzBuzz.GetFizzBuzz(15);

            Assert.AreEqual("Fizz", result1);
            Assert.AreEqual("Buzz", result2);
            Assert.AreEqual("FizzBuzz", result3);
        }

        [TestMethod]
        public void ValidaFizzBuzzIsFalse()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.GetFizzBuzz(7);

            Assert.AreEqual("Not FizzBuzz", result);


        }

        #endregion


        #region ChunkArray

        [TestMethod]
        public void ValidaChunkingArrayAreEqualOne()
        {
            ChunkArray chunk = new ChunkArray();

            int[] array = new int[] { 1, 2, 3, 4, 5};

            int result = chunk.ChunkingArray(array, 10);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ValidaChunkingArrayAreEqualTwo()
        {
            ChunkArray chunk = new ChunkArray();

            int[] array = new int[] {1, 2, 3, 4};

            int result = chunk.ChunkingArray(array, 2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ValidaChunkingArrayAreEqualTwoSecondExample()
        {
            ChunkArray chunk = new ChunkArray();

            int[] array = new int[] { 1, 2, 3, 4, 5};

            int result = chunk.ChunkingArray(array, 4);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ValidaChunkingArrayAreEqualThree()
        {
            ChunkArray chunk = new ChunkArray();

            int[] array = new int[] { 1, 2, 3, 4, 5};

            int result = chunk.ChunkingArray(array, 2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void ValidaChunkingArrayAreEqualThreeSecondExample()
        {
            ChunkArray chunk = new ChunkArray();

            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8};

            int result = chunk.ChunkingArray(array, 3);

            Assert.AreEqual(3, result);
        }

        #endregion


        #region Anagram

        [TestMethod]
        public void ValidateAnagramIsTrue()
        {
            Anagrams anagram = new Anagrams();

            var result1 = anagram.IsAnagram("rail safety", "fairy tales");
            Assert.IsTrue(result1);
        }

        [TestMethod]
        public void ValidateAnagramIsFalse()
        {
            Anagrams anagram = new Anagrams();

            var result = anagram.IsAnagram("Hi there", "Bye there");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateAnagramSpecialCaracterRemove()
        {
            Anagrams anagram = new Anagrams();

            var result = anagram.IsAnagram("RAIL! SAFETY!", "fairy tales");

            Assert.IsTrue(result);
        }

        #endregion


        #region SentenceCapitalization

        [TestMethod]
        public void FirstLetterCapitalizationAreEqual()
        {
            SentenceCapitalization sentence = new SentenceCapitalization();

            var result = sentence.FirstLetterCapitalization("a short sentence");

            Assert.AreEqual("A Short Sentence", result);

        }

        [TestMethod]
        public void FirstLetterCapitalizationAreEqualWithPontuaction()
        {
            SentenceCapitalization sentence = new SentenceCapitalization();

            var result = sentence.FirstLetterCapitalization("look, it is working!");

            Assert.AreEqual("Look, It Is Working!", result);

        }

        #endregion
    }
}
