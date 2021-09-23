using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05NestedForLoopsAnd2DArrays
{
    class Program
    {
        static int[,] matrix =
        {
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 },
            {10, 11, 12 }
        };

        static int[,] matrix2 =
        {
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 }
        };
        static void Main(string[] args)
        {
            foreach (int num in matrix)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\n--------------------");
            Console.WriteLine("");
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine("\n--------------------");
            Console.WriteLine("");

            // Nested for loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i, j]);
                }
            }

            Console.WriteLine("\n--------------------");
            Console.WriteLine("");
            // Print only even numbers
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        Console.WriteLine(matrix[i, j]);
                    }
                }
            }

            Console.WriteLine("\n--------------------");
            Console.WriteLine("");
            // Print diagonal numbers starting from upper left to bottom right

            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                    Console.WriteLine(matrix2[i, i]);
            }

            Console.WriteLine("\n--------------------");
            Console.WriteLine("");
            // Print numbers diagonally
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n--------------------");
            Console.WriteLine("");
            // Print diagonal numbers starting from upper right to bottom left
            for (int i = 0, j = matrix2.GetLength(1) - 1; i < matrix2.GetLength(0); i++, j--)
            {
                Console.WriteLine(matrix2[i, j]);
            }
            //0,2
            //1,1
            //2,0
            /*
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 }
            */

            Console.WriteLine("\n--------------------");
            Console.WriteLine("");
            // Print diagonal numbers starting from lower right to upper left
            for (int i = matrix2.GetLength(0) - 1; i >= 0; i--)
            {
                Console.WriteLine(matrix2[i, i]);
            }
            //2,2
            //1,1
            //0,0
            /*
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 }
            */

            Console.WriteLine("\n--------------------");
            Console.WriteLine("");
            // Print diagonal numbers starting from lower left to upper right
            for (int i = 0, j = matrix2.GetLength(1) - 1; i < matrix2.GetLength(0); i++, j--)
            {
                Console.WriteLine(matrix2[j, i]);
            }
            //2,0
            //1,1
            //0,2
            /*
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 }
            */




            Console.ReadLine();
        }
    }
}
