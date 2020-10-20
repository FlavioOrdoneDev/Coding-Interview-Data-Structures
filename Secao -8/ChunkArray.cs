using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coding_Interview_Algorithms_Data_Structures.Secao__8
{
    public class ChunkArray
    {

        public int ChunkingArray(int[] array1, int size)
        {
            //int[] array1 = new int[5];
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array1[i] = i;
            //}

            // Split into smaller arrays of maximal 30 elements
            IEnumerable<IEnumerable<int>> splited = array1.Split<int>(size);
            int quantidade = 0;
            foreach (IEnumerable<int> s in splited)
            {
                quantidade++;
            }
            
            return quantidade;
        }        
    }

    public static class MyArrayExtensions
    {
        public static IEnumerable<IEnumerable<T>> Split<T>(this T[] array, int size)
        {
            for (var i = 0; i < (float)array.Length / size; i++)
            {
                yield return array.Skip(i * size).Take(size);
            }
        }
    }
}
