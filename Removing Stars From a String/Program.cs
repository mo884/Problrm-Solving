namespace Removing_Stars_From_a_String
{
    internal class Program
    {
        static string RemoveStars(string s)
        {
            //int star = 0;
            //StringBuilder sb = new StringBuilder();
            //for (int i = s.Length-1;i>=0;i--)
            //{

            //    if (s[i] == '*')
            //    {
            //        star++;
            //        sb.Append(s[i]);
            //    }

            //    else if (star>0)
            //    {
            //        sb.Append('*');
            //        star--;
            //    }
            //    else
            //    {
            //        sb.Append(s[i]);
            //    }




            //}
            //string text = sb.ToString();
            //string Finalstring = "";
            //for (int i = text.Length-1 ; i >=0 ; i--)
            //{
            //    if (text[i]!='*')
            //        Finalstring += text[i];
            //}
            //return Finalstring;


            Stack<char> charStack = new Stack<char>();
            foreach (char cha in s)
            {
                if (cha == '*')
                {
                    charStack.Pop();
                }
                else
                {
                    charStack.Push(cha);
                }
            }
            return new string(charStack.Reverse().ToArray());
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine(RemoveStars("leet**cod*e"));
        }
    }
}
