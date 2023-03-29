//Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.

//If target is not found in the array, return [-1, -1].

//You must write an algorithm with O(log n) runtime complexity.


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
            int leftIndex = FindIndex(nums, target, true); // find the leftmost index of the target
            int rightIndex = FindIndex(nums, target, false); // find the rightmost index of the target
            return new int[] { leftIndex, rightIndex };
        }

        // helper method to find the leftmost or rightmost index of the target using binary search
        static private int FindIndex(int[] nums, int target, bool isLeft)
        {
            int start = 0;
            int end = nums.Length - 1;
            int index = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                {
                    index = mid;
                    if (isLeft)
                    { // look for the leftmost index of the target
                        end = mid - 1;
                    }
                    else
                    { // look for the rightmost index of the target
                        start = mid + 1;
                    }
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return index;
        }
    }
}
