using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Interview_Algorithms_Data_Structures.Secao_10
{
    public class SentenceCapitalization
    {
        public string FirstLetterCapitalization(string text)
        {
            string frase = "";

            char[] delimitadores = new char[] { ' ' };
            string[] strings = text.Split(delimitadores);            

            foreach (var item in strings)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (frase.Length == 0)
                        frase += item[i].ToString().ToUpper();
                    else if (frase.Length != 0 && i == 0)
                        frase += " " + item[i].ToString().ToUpper();
                    else
                        frase += item[i];
                }
            }

            return frase;
        }
    }
}
