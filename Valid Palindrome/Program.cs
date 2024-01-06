namespace Valid_Palindrome
{
    internal class Program
    {
        static bool IsPalindrome(string s)
        {

            Stack<char> reverse = new Stack<char>();
            string text = "";
            s = s.ToLower();
            for (int i = 0; i<s.Length; i++)
            {
                if (s[i] >='a'&& s[i] <='z'|| (s[i] >= '0' && s[i] <= '9'))
                {
                    reverse.Push(s[i]);
                    text +=s[i];
                }
            }
            for (int i = 0; i < text.Length/2; i++)
            {
                if (text[i]!=reverse.Pop())
                    return false;
            }
            return true;



            //List<char> list = new List<char>();

            //s = s.ToLower();

            //for (int i = 0; i < s.Length; i++)
            //{
            //    char c = s[i];
            //    if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
            //    {
            //        list.Add(c);
            //    }
            //}

            
            //for (int i = 0; i<list.Count/2; i++)
            //{
            //    if (list[i] != list[list.Count-1-i])
            //    {
            //        return false;
            //    }
            //}
            //return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("race a car"));
        }
    }
}
