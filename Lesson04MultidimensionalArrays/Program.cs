using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare 2d array
            string[,] matrix;

            // Declare 3d array
            int[,,] threeD;

            int[,] array2D = new int[,]
            {
                {1, 2, 3}, // row 0
                {4, 5, 6}, // row 1
                {7, 8, 9}  // row 2
            };

            Console.WriteLine("Center value: " + array2D[1,1]);
            Console.WriteLine("7 - " + array2D[2,0]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001" },
                    {"010", "011" }
                },
                {
                    {"100", "101" },
                    {"110", "111" }
                }
            };
            Console.WriteLine("011 - " + array3D[0, 1, 1]);

            // 2D string array with 3 rows and 2 entries per row
            int[,] newMDArray = new int[3, 2] 
            { 
                { 1, 2 }, 
                { 3, 4 }, 
                { 5, 6 } 
            };

            // Change 6 to 8 in newMDArray
            newMDArray[2, 1] = 8;
            foreach(int i in newMDArray)
            {
                Console.WriteLine(i);
            }

            // Check how many dimensions an array has
            int dimensions = newMDArray.Rank;
            Console.WriteLine($"newMDArray has {dimensions} dimensions");

            // Another way to initalize a multidimensional array
            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

            Console.ReadLine();
        }
    }
}
