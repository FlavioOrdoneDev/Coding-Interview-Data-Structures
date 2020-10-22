using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Interview_Algorithms_Data_Structures
{
    public class FindVowels
    {

        public int CountVowels(string frase)
        {
            string letras = "aeiou";
            int count = 0;

            foreach (var item in frase)
            {
                if (letras.Contains(item))
                    count++;
            }

            return count;
        }
        
    }
}
