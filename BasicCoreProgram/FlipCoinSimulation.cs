
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class FlipCoinSimulation
    {
        public int FlipHeads = 0;
        public int FlipHails = 0;
        const double ConstastDec = 0.5;


        public void CheckHeadTailPercentage()
        {
            Console.WriteLine("Enter How many times you want to Flip a Coin : ");
            int FlipNumber = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int coinFlip = 1; coinFlip <= FlipNumber; coinFlip++)
            {

                //Check Reandom 
                double CheckFlipCoin = random.Next(0, 2);
                if (CheckFlipCoin < ConstastDec)
                {
                    //If head
                    Console.WriteLine("Result: Is Head");
                    FlipHeads++;
                }
                else
                {
                    //if tail 
                    Console.WriteLine("Result: Is Tail");
                    FlipHails++;
                }
            }
            //Calculating Percentage
            double CheckPercentageTails = (FlipHeads * 100) / FlipNumber;
            double CheckPercentageHeads = (FlipHails * 100) / FlipNumber;
            Console.WriteLine("percentage of TAILS and HEADS is : " + CheckPercentageTails + " " + CheckPercentageHeads);
            Console.ReadKey();
        }

    }
}
