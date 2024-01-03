namespace Length_of_Last_Word
{
    internal class Program
    {
        static int LengthOfLastWord(string s)
        {
            int count = 0;
            for (int i = s.Length-1; i>=0; i--)
            {
                if (s[i] != ' ')
                    count++;
                else
                    if (count>0)
                    return count;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
        }
    }
}
