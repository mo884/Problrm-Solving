using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LeetCode
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
           
            /*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

            You may assume that each input would have exactly one solution, and you may not use the same element twice.

             You can return the answer in any order.*/
            Dictionary<int ,int> dictionary = new Dictionary<int, int> ();
            for (int i = 0; i < nums.Length; i++)
            {
                int Element = target-nums[i];
                if (!dictionary.ContainsKey(Element))
                    dictionary.Add(nums[i], i);

                if (dictionary.ContainsKey(Element)&& dictionary[Element]!=i)
                    return new int[] { i, dictionary[Element] };
            }                                   
            return new int[] { 0 };
        }





        //public int[] TwoSum(int[] nums, int target)
        //{

        //    /*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        //    You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //     You can return the answer in any order.*/
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] + nums[i+1]== target)
        //            return new int[] { i, i+1 };
        //        else
        //            for (int j = i+2; j<nums.Length; j++)
        //                if (nums[i]+nums[j]==target)
        //                    return new int[] { i, j };
        //    }
        //    return new int[] { 0 };
        //}

        //Another Solution
        //public int[] TwoSum( int target, int[] nums)
        //{

        //    /*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        //    You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //     You can return the answer in any order.*/

        //    //int j = nums.Length-1;
        //    //for (int i = 0; ;)
        //    //{
        //    //    if (nums[i]+nums[j]>target)
        //    //        j--;
        //    //    else if (nums[i]+nums[j]<target)
        //    //        i++;
        //    //    else
        //    //        return new int[] { i, j };
        //    //}
        //    //return new int[] { 0 };



        //    //for (int i = 0,j=1;j<nums.Length; j++)
        //    //{
        //    //    if (nums[i]+nums[j]==target)
        //    //        return new int[] { i, j };
        //    //    if(j==nums.Length-1)
        //    //    {
        //    //        j=i+1;
        //    //        i++;
        //    //    }

        //    //}
        //    //return new int[] { 0 };

        //}
    }
}
