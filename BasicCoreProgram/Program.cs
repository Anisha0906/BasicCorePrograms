using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");
            Console.WriteLine("Enter your choice between 1 to 10: ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1 For: Flip a Coin Head and Tail. ");
            Console.WriteLine("2 For: Select Value is Leap Year Or not");
            Console.WriteLine("3 For: Select Power of 2 Number");

            int selection = Convert.ToInt32(Console.ReadLine());
         

            switch (selection)
            {
                case 1:
                    FlipCoinSimulation FlipCoin = new FlipCoinSimulation();
                    FlipCoin.CheckHeadTailPercentage();
                    break;
                case 2:
                    LeapYearOrNot LeapYearOrNot = new LeapYearOrNot();
                    LeapYearOrNot.LeapYear();
                    break;
                case 3:
                    PowerOf2 CalPower = new PowerOf2();
                    CalPower.CalcuOfPower();
                    break;
                case 4:
                    HarmonicNumber CalculateHarmonicNumber = new HarmonicNumber();
                    CalculateHarmonicNumber.CalcHarmonicSeries();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Select inBetween 1 to 3");
                    break;
            }
            Console.ReadLine();
        }
    }
}