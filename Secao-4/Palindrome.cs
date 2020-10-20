using Coding_Interview_Algorithms_Data_Structures.Secao_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Interview_Algorithms_Data_Structures.Secao_4
{
    public class Palindrome
    {
        public bool ValidatePalindrome(string word)
        {
            char[] result = word.ToCharArray();
            Array.Reverse(result);

            var newResult = new string(result);

            if (newResult == word)
                return true;

            return false;
                
        }

        public bool ValidatePalindromeLoop(string word)
        {
            var reversed = "";

            foreach (var item in word)
            {
                reversed = item + reversed; 
            }

            if (reversed.Equals(word))
                return true;

            return false;
        }
    }
}
