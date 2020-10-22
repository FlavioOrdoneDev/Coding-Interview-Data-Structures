using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Interview_Algorithms_Data_Structures
{
    public class PrintingSteps
    {
        public string PrintingStepsFor(int size)
        {
            string result = "";
            for (int row = 0; row < size; row++)
            {
                string star = "";
                for (int column = 0; column < size; column++)
                {
                    if (column <= row)
                        star += "*";
                    else
                        star += " ";
                }
                result = "'" + star + "'";
            }

            return result;
        }

        public string PrintingStepsRecursive(int size)
        {
            return Steps(size);
        }

        public string Steps(int n, int row = 0, string stair = "")
        {
            if (n == row)
                return stair;

            if (n == stair.Length)
            {
                Console.WriteLine("'" + stair + "'");
                return Steps(n, row + 1);
            }

            if (stair.Length <= row)
                stair += "*";
            else
                stair += " ";

            // Erro: retornando espaços em branco
            return Steps(n, row, stair);
        }
    }
}
