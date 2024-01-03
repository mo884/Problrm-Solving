namespace reverse_integer
{
    internal class Program
    {
        static int Reverse(int x)
        {
            int overflowLimit = int.MaxValue / 10;
            int num = 0;
            bool IsPostive;
            if (x>0)
            {
                IsPostive=true;
            }
            else
            {
                IsPostive =false;
                x *= -1;
            }

            while (x>0)//1534236469 //9646324351
            {
                if (num > overflowLimit)
                    return 0;
                num = num*10 + x%10;
                x/=10;
            }
            if (IsPostive)
                return num;

            return num*-1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(96463));
        }
    }
}
