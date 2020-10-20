using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Interview_Algorithms_Data_Structures.Secao_7
{
    public class FizzBuzz
    {
        public string GetFizzBuzz(int number)
        {
            string result = "";

            if (number % 3 == 0 && number % 5 == 0)
                result = "FizzBuzz";
            else if (number % 3 == 0)
                result = "Fizz";
            else if (number % 5 == 0)
                result = "Buzz";
            else 
                result = "Not FizzBuzz";

            return result;
        }
    }
}
