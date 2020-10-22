using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Coding_Interview_Algorithms_Data_Structures
{
    public class RuntimeComplexity
    {

        public int FibonacciSeries(int n)
        {
            int num1 = 0;
            int num2 = 1;
            int aux;

            for (int i = 0; i < n; i++)
            {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;
            }
            return num2;
        }

        public int FibonacciSeriesRecursive(int n)
        {
            int result = 0;

            if (n > 1)
                result = FibonacciSeriesRecursive(n - 1) + FibonacciSeriesRecursive(n - 2);

            if (n <= 1)
                result = 1;

            return result;
        }

        
    }
}
