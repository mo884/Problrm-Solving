namespace Reverse_String
{
    internal class Program
    {
        public void ReverseString(char[] s)
        {
            int i = 0;
            int j = s.Length-1;
            while (i < j)
            {
                char temp = s[i];
                s[i++] = s[j];
                s[j--] = temp;
            }
        }
        static void Main(string[] args)
        {
            char[] name = { 'A','H','M','E','D','1'};
            Program P = new Program();
            P.ReverseString(name);
            Console.WriteLine("Hello, World!");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }
    }
}
