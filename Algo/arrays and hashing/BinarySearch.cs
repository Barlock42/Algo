﻿//There is an integer array nums sorted in ascending order (with distinct values).

//Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k (1 <= k < nums.length) such that the resulting array is [nums[k], nums[k + 1], ..., nums[n - 1], nums[0], nums[1], ..., nums[k - 1]] (0 - indexed).For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3 and become [4,5,6,7,0,1,2].

//Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.

//You must write an algorithm with O(log n) runtime complexity.


using System;
namespace Algo
{
    public class BinarySearch
    {
        static public int FindIndex(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int index = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else
                {
                    if (nums[left] <= nums[mid])
                    {
                        // Left half of the array is sorted
                        if (target >= nums[left] && target < nums[mid])
                        {
                            // Target is within the range of the left half
                            right = mid - 1;
                        }
                        else
                        {
                            // Target is not within the range of the left half
                            left = mid + 1;
                        }
                    }
                    else
                    {
                        // Right half of the array is sorted
                        if (target > nums[mid] && target <= nums[right])
                        {
                            // Target is within the range of the right half
                            left = mid + 1;
                        }
                        else
                        {
                            // Target is not within the range of the right half
                            right = mid - 1;
                        }
                    }
                }
            }

            // nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            return index;
        }
    }
}
