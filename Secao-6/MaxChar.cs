using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Coding_Interview_Algorithms_Data_Structures.Secao_6
{
    public class MaxChar
    {
        public Dictionary<char, int> ObterMaxChar(string str)
        {
            str = str.Replace(" ", "");
            
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (dict.ContainsKey(c)) dict[c] = dict[c] + 1;
                else dict.Add(c, 1);
            }
            
            var ordered = dict.OrderByDescending(x => x.Value)
              .ToDictionary(d => d.Key, d => d.Value);

            var result = ordered.Take(1)
              .ToDictionary(d => d.Key, d => d.Value);

            return result;
        }










        //public Dictionary<char, int> ObterMaxChar(string str)
        //{
        //    //string strValidated = "";
        //    str = str.Replace(" ", "");     //Remove all spaces

        //    //Validate alpha-numberic only
        //    //if (Regex.IsMatch(str, @"^[A-Za-z0-9]+$")) strValidated = str;
        //    //else throw new FormatException("--------> Only Apha Numeric values allowed");

        //    Dictionary<char, int> dict = new Dictionary<char, int>();

        //    foreach (char c in str)    //Create Dictionary
        //    {
        //        if (dict.ContainsKey(c)) dict[c] = dict[c] + 1;
        //        else dict.Add(c, 1);
        //    }
        //    //Sort(K,V) by Highest Values
        //    var ordered = dict.OrderByDescending(x => x.Value)
        //      .ToDictionary(d => d.Key, d => d.Value);

        //    //var singleEntryDict = ordered.First();  
        //    var result = ordered.Take(1)
        //      .ToDictionary(d => d.Key, d => d.Value);

        //    return result;
        //}
    }
}
