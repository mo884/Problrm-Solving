namespace Plindrome_Number
{
    internal class Program
    {


        /// <summary>
        /// Best Solution 
        /// </summary>
        /// 


        static bool IsPalindrome(int x)
        {
            int number = x;
            int reverseNumber =0;
            
            while(number !=0)
            {
                reverseNumber = number %10 + reverseNumber *10;
                number = number /10;
            }
            return reverseNumber==x;
        }
            //static bool IsPalindrome(int x)
            //{


            //    //string number = Convert.ToString(x);
            //    //if (number[0]=='-')
            //    //    return false;
            //    //if (number.Length == 1)
            //    //    return true;

            //    //string reversenumber = "";
            //    //for (int i = number.Length-1; i>=0; i--)
            //    //{
            //    //    reversenumber +=number[i];
            //    //}
            //    //if (string.Equals(number, reversenumber))
            //    //    return true;
            //    //return false;
            //}
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(121));

        }
    }
}
