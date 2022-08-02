using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class EvenOrOdd
    {
        public int Num;
        public int Rem;
        public void CheckEvenOrdd()
        {

            Console.Write("Enter Number to Check whether Number is Even or Odd :\n");
            Num = Convert.ToInt32(Console.ReadLine());
            Rem = Num % 2;
            if (Rem == 0)
                Console.WriteLine("{0} is an Even Number.", Num);
            else
                Console.WriteLine("{0} is an Odd Number.", Num);
        }
    }
}
