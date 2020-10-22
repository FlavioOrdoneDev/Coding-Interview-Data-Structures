using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Coding_Interview_Algorithms_Data_Structures
{
    public class Anagrams
    {

        public bool IsAnagram(string word1, string word2)
        {
            word1 = word1.Replace(" ", "").ToLower();
            word2 = word2.Replace(" ", "").ToLower();

            word1 = Regex.Replace(word1, "[^0-9a-zA-Z]+", "");
            word2 = Regex.Replace(word2, "[^0-9a-zA-Z]+", "");

            var dict1 = GetDictionary(word1);
            var dict2 = GetDictionary(word2);

            var result = ValidateAnagram(dict1, dict2);            

            return result;
        }

        public Dictionary<char, int> GetDictionary(string word)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in word)
            {
                if (dict.ContainsKey(c)) dict[c] = dict[c] + 1;
                else dict.Add(c, 1);
            }

            var ordered = dict.OrderByDescending(x => x.Value)
              .ToDictionary(d => d.Key, d => d.Value);

            return ordered;
        }

        public bool ValidateAnagram(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
        {
            return DictionaryExtensionMethods.ContentEquals(dict1, dict2);
        }                
    }

    public static class DictionaryExtensionMethods
    {
        public static bool ContentEquals<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, Dictionary<TKey, TValue> otherDictionary)
        {
            return (otherDictionary ?? new Dictionary<TKey, TValue>())
                .OrderBy(kvp => kvp.Key)
                .SequenceEqual((dictionary ?? new Dictionary<TKey, TValue>())
                                   .OrderBy(kvp => kvp.Key));
        }
    }
}
