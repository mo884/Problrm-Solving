using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheet_Assiut_Problem_Solving
{
    public class Factorial
    {
        public int Fact(int number)
        {
            if (number == 2)
                return 2;
            return number * Fact(number - 1);
        }
    }
}
