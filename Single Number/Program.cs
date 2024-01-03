using System.Collections.Immutable;

namespace Single_Number
{
    internal class Program
    {
        static int SingleNumber(int[] nums)
        {
            //List<int> list = new List<int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (!list.Contains(nums[i]))
            //        list.Add(nums[i]);
            //    else
            //        list.Remove(nums[i]);
            //}
            //return list.FirstOrDefault();

            Array.Sort(nums);
            for (int i = 0; i<nums.Length-1; i+=2)
            {
                if (nums[i]!=nums[i+1])
                {
                    return nums[i];
                }
            }
            return nums[nums.Length-1];

        }
        static void Main(string[] args)
        {
            Console.WriteLine(SingleNumber([2, 2, 1]));
        }
    }
}
