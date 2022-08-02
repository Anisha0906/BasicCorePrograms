using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class PrimeFactorization
    {
        public int Var_j = 0;
        public int num = 0;
        public int factorial = 1;
        public void CalcSFactorialSeries()
        {
            Console.Write("Calculate the factorial of a given number:"); 
            num = Convert.ToInt32(Console.ReadLine());
            for (Var_j = 1; Var_j <= num; Var_j++)  
                factorial *= Var_j; 
            Console.Write("The Factorial of {0} is: {1}\n", num, factorial);
        }
    }
}
