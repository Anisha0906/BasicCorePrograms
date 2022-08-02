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
            Console.WriteLine("4 For: Select the Harmonic Number");
            Console.WriteLine("5 For: Select Factors of number");
            Console.WriteLine("6 For: Select Quotient and Remainder");
            Console.WriteLine("7 For: Select Swap the Numbers");
            Console.WriteLine("8:Select Even and Odd number");
            Console.WriteLine("9 For: Select Alphabet Vowel");
            Console.WriteLine("10 For: Select Greatest number among Three");
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
                case 5:
                    PrimeFactorization PrimeFactor = new PrimeFactorization();
                    PrimeFactor.CalcSFactorialSeries();
                    break;
                case 6:
                    QusRemaindercs QuesRem = new QusRemaindercs();
                    QuesRem.QuotientRemainder();
                    break;
                case 7:
                    Swap2Number SwapTwoNo = new Swap2Number();
                    SwapTwoNo.SwapTwoNumber();
                    break;
                case 8:
                    EvenOrOdd EvenOdd = new EvenOrOdd();
                    EvenOdd.CheckEvenOrdd();
                    break;
                case 9:
                    VowelOrNot VowelNot = new VowelOrNot();
                    VowelNot.CheckGivenVowel();
                    break;
                case 10:
                     CheckGreaterOrSmallest checkgreaterOrSmallest = new CheckGreaterOrSmallest();
                    checkgreaterOrSmallest.GreaterOrSmaller();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Select inBetween 1 to 3");
                    break;
            }
            Console.ReadLine();
        }
    }
}