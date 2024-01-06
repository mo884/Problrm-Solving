namespace Missing_Number
{
    internal class Program
    {
        static int MissingNumber(int[] nums)
        {
            Array.Sort(nums);
            if (nums[0]!=0)
                return nums[0]-1;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i]+1!=nums[i+1])
                    if (i != nums.Length-1)
                        return nums[i]+1;
            }
            return nums[nums.Length-1]+1;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(MissingNumber([0, 1]));
        }
    }
}
