using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class QusRemaindercs
    {
        public int Dividend = 0;
        public int Divisor = 0;
        public void QuotientRemainder()
        {
            Console.Write("Calculate the Dividend:"); 
            Dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Calculate the Divisor:"); 
            Divisor = Convert.ToInt32(Console.ReadLine());
            int AndQuotient = Dividend / Divisor;  
            int AndRemainder = Dividend % Divisor; 

            Console.WriteLine("Dividend:{0} Divisor:{1}", Dividend, Divisor);
            Console.WriteLine("Quotient = " + AndQuotient); 
            Console.WriteLine("Remainder = " + AndRemainder);
            Console.ReadLine();
        }
    }
}
