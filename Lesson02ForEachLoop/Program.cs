using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 10;
            }

            /*for(int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine(nums[j]);
            }*/

            foreach(int value in nums)
            {
                Console.WriteLine(value);
            }

            string[] friends = { "Djole", "Nidza", "Milan", "Nesa", "Dule" };
            foreach(string friend in friends)
            {
                Console.WriteLine(friend);
            }

            Console.ReadLine();
        }
    }
}
