using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "1";
            string two = "2";
            string three = "3";
            string four = "4";
            string five = "5";
            string six = "6";
            string seven = "7";
            string eight = "8";
            string nine = "9";
            
            while(nine == "9")
            {
                Console.WriteLine("     |     |     ");
                Console.WriteLine($"  {one}  |  {two}  |  {three}  ");
                Console.WriteLine("     |     |     ");
                Console.WriteLine("-----------------");
                Console.WriteLine("     |     |     ");
                Console.WriteLine($"  {four}  |  {five}  |  {six}  ");
                Console.WriteLine("     |     |     ");
                Console.WriteLine("-----------------");
                Console.WriteLine("     |     |     ");
                Console.WriteLine($"  {seven}  |  {eight}  |  {nine}  ");
                Console.WriteLine("     |     |     ");

                Console.WriteLine("");


                Console.WriteLine("Enter number from 1 to 9: ");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        one = "o";
                        break;
                    case 2:
                        two = "o";
                        break;
                    case 3:
                        three = "o";
                        break;
                    case 4:
                        four = "o";
                        break;
                    case 5:
                        five = "o";
                        break;
                    case 6:
                        six = "o";
                        break;
                    case 7:
                        seven = "o";
                        break;
                    case 8:
                        eight = "o";
                        break;
                    case 9:
                        nine = "o";
                        break;
                }
                Console.Clear();

            }


            Console.ReadLine();
        }
    }
}
