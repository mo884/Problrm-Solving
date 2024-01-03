namespace Happy_Number
{
    internal class Program
    {
        static bool IsHappy(int n)
        {
            List<int> l = new List<int>();
            int Number = 0;
            while (n > 0)
            {
                int x;
                Number = 0;
                while (n > 0)
                {
                    x = n%10;
                    n /= 10;
                    Number += x*x;
                }
                n = Number;
                if (Number ==1)
                    return true;
                if (!l.Contains(Number))
                    l.Add(Number);
                else
                    return false;
            }
            return false;

        }
        static void Main(string[] args)
        {
             Console.WriteLine(IsHappy(2));
        }
    }
}
