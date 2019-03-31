using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TwoDimArray
    {
        static void Main(string[] args)
        {
            int[][] array = new int[2][] { new int[3] {1, 2, 3}, new int[3] {4, 5, 6} };
            for (int j = 0; j < array.Length; j += 1) {
                for (int k = 0; k < array[j].Length; k += 1) {
                    Console.Write(array[j][k]);
                }
            }
            Console.ReadKey();
        }
    }
