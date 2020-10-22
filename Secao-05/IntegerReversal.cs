using System;

namespace Coding_Interview_Algorithms_Data_Structures
{
    public class IntegerReversal
    {
        public int ReverseInteger(int number)
        {
            var numberString = number.ToString();
            var numberRP = numberString.Replace("-", null);
            char[] result = numberRP.ToCharArray();
            Array.Reverse(result);

            return int.Parse(result) * Math.Sign(number); 
        }
    }
}
