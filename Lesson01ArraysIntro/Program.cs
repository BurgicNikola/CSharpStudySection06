using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01ArraysIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initailze and declare grades array
            int[] grades = new int[5];

            // Assign values
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 17;
            grades[3] = 14;
            grades[4] = 9;

            Console.WriteLine($"Grades at index 0: {grades[0]}");

            string input = Console.ReadLine();
            // Assign value to array grades at index 0
            grades[0] = int.Parse(input);

            Console.WriteLine($"Grades at index 0: {grades[0]}");

            // Another way of initailizng an array
            int[] gradesOfMathStudents = { 20, 8, 17, 15, 15, 16 , 8};

            // Third way of initailizing an array
            int[] gradesOfChemistryStudents = new int[] { 15, 14, 17, 15, 20, 9 };

            Console.WriteLine(gradesOfChemistryStudents.Length);
            Console.WriteLine(gradesOfMathStudents.Length);
            Console.ReadLine();
        }
    }
}
