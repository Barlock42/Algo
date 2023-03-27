using System;

namespace Algo
{
    public class Algo
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
            SearchRange(nums, 8);

            Console.WriteLine("Hello World!");


        }

        static public int[] SearchRange(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length-1;

            int middle = (left + right) / 2;




            return new int[] { -1, -1 };
        }
    }
}
