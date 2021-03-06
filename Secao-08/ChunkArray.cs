﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coding_Interview_Algorithms_Data_Structures
{
    public class ChunkArray
    {

        public int ChunkingArray(int[] array1, int size)
        {
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
