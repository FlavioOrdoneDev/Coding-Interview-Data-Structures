using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Interview_Algorithms_Data_Structures
{
    public class StepsPyramid
    {
        public string StepsPyramidsFor(int size)
        {
            int i, j, n;
            n = size;
            string result = "";
            for (i = 0; i < n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            return result;
        }
    }
}
