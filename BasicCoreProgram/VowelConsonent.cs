using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class VowelOrNot
    {
        public char Alphabet;
        public void CheckGivenVowel()
        {
            Console.Write("Check whether the input  Alphabet (A-Z or a-z) is a vowel or not:\n"); 
            Alphabet = Convert.ToChar(Console.ReadLine()); 
            if (Alphabet == 'a' | Alphabet == 'A' | Alphabet == 'i' | Alphabet == 'I' | Alphabet == 'U' | Alphabet == 'u' | Alphabet == 'E' | Alphabet == 'e' | Alphabet == 'O' | Alphabet == 'o')
                Console.WriteLine("Given" + " " + Alphabet + " is a Vowel"); 
            else
                Console.WriteLine("Given" + " " + Alphabet + " is a Consonant"); 
        }
    }
}