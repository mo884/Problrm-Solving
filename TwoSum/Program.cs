namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            /*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

            You may assume that each input would have exactly one solution, and you may not use the same element twice.

             You can return the answer in any order.*/

            Solution solution = new Solution();
            int [] arr =solution.TwoSum( new int[] { 3, 2, 4 }, 6);//0,2
            if(arr.Length != 1) 
            {
                Console.WriteLine($"[{arr[0]},{arr[1]}]");
            }
            
           
           
            #endregion
        }
    }
}
