using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coding_Interview_Algorithms_Data_Structures.Secao_3
{
    public class ReverseString
    {
        public string ReverseString1(string word)
        {
            return new string(word.Reverse().ToArray()); 
        }

        /*
            passos
                Tornar a string em um array
                Reverter os caracteres
                Juntar novamente os caracteres
                Retornar o resultado
        */

        public string ReverseString2(string word)
        {
            char[] result = word.ToCharArray();
            Array.Reverse(result);

            return new string(result);
        }

        /*
            passos
                declarar uma string vazia
                percorrer um loop foreach
                Retornar o resultado
        */

        public string ReverseStringLoop(string word)
        {
            var reversed = "";
            
            foreach (var item in word)
            {
                reversed = item + reversed;
            }

            return new string(reversed);
        }
    }
}
