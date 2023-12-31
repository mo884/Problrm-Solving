using System.ComponentModel;
using System.Data;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sheet_Assiut_Problem_Solving
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Given a number N. Print numbers from 1 to N in separate lines.
            //Console.Write("Plz Enter Your Nummber :");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Task 2
            //Given a number N. Print all even numbers between 1 and N inclusive in separate lines.
            //Print the answer according to the required above. If there are no even numbers print -1.
            /*Console.Write("Plz Enter Your Nummber :");
            int num = int.Parse(Console.ReadLine());
            bool even = true;
            for (int i = 1; i <= num; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                    even = false;
                }
                
            }
            if (even)
                Console.WriteLine(-1);
            */
            #endregion

            #region Task 3
            //Given N numbers. Count how many of these values are even, odd, positive and negative.
            //int Nummber;
            //Console.Write("Plz Enter Your Nummber :");
            //int num = int.Parse(Console.ReadLine());
            //int[] method = new int[4];
            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write("Plz Enter Your Nummber :");
            //    Nummber= int.Parse(Console.ReadLine());
            //    if (Nummber%2==0)
            //        method[0]++;
            //    else
            //        method[1]++;
            //    if(Nummber>0)
            //        method[2]++;
            //    if (Nummber<0)
            //        method[3]++;
            //}
            //Console.WriteLine($"Events : {method[0]}\nOdd : {method[1]}\nPositive :{method[2]}\nNegative : {method[3]} ");
            #endregion

            #region Task 3

            ///Given multiple lines each line contains a number X which is a password. Print "Wrong" if the password is incorrect otherwise, print "Correct" and terminate the program.
            //int password =1990;
            //int checkPassword;
            //bool IsCorrect = true;
            //do
            //{

            //    Console.Write("Plz Enter Your Password :");
            //    checkPassword = int.Parse(Console.ReadLine());
            //    if (checkPassword != password)
            //    {
            //        IsCorrect = false;
            //        Console.WriteLine("Wrong");
            //    }
            //    else
            //    {
            //        IsCorrect = true;
            //        Console.WriteLine("Correct");
            //    }

            //} while (!IsCorrect);
            #endregion

            #region Task 4
            //Given a number N, and N numbers, find maximum number in these N numbers.

            /*Console.Write("Plz Enter Your Nummber :");
            int num = int.Parse(Console.ReadLine());
            int[] Numbers = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write($"Plz Enter Your Nummber {i+1}:");
                Numbers[i]= int.Parse(Console.ReadLine());
            }

            int Max = Numbers[0];
            for (int i = 1; i < num; i++) 
            {
                if (Numbers[i]> Max)
                    Max= Numbers[i];
            }
            Console.WriteLine(Max);*/
            #endregion

            #region Task5
            //Given a number N. Print the maltiplication table of the number from 1 to 12
            /*Console.Write("Plz Enter Your Nummber :");
            int maltiplNumber = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {maltiplNumber} = {maltiplNumber*i}");
            }
            */

            #endregion

            #region Task5
            //Given a number N. Print the factorial of number N.
            Console.Write("Plz Enter Your Nummber :");
            int factorialNumber = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= factorialNumber; i++)
            {
                factorial *=i;
            }
            Console.WriteLine(factorial);
            //Second Method By Using Recursion
            Factorial factorial1 = new Factorial();
            int result = factorial1.Fact(factorialNumber);
            Console.WriteLine(result);
            #endregion

           
        }
    }
}
