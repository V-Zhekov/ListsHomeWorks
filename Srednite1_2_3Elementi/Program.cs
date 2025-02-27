using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srednite1_2_3Elementi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int n = nums.Length;
            if (nums.Length == 1) Console.WriteLine(nums[0]);
            int mid = n / 2;
            if (n % 2 == 0)
            {
                Console.WriteLine($"{nums[mid - 1]},{nums[mid]}");
                Console.WriteLine(nums[mid]);
            }
            else
            {
                Console.WriteLine($"{nums[mid - 1]},{nums[mid]},{nums[mid+1]}");
            }
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write($"{nums[i]},");
            //}
        }
    }
}
