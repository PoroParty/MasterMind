using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mastermind();
        }
        static void Mastermind()
        {

            // Her under skal alt nultstilles og en randomizer skal ændre farverne på masterCode array. 




            // fra her af skal der laves et loop, alt under her bliver nød til at virke i et loop. 

            // laver 2 lister/array, masterCode er selve koden som skal gættes. og codeGuess we hvor ens farver man gætter på kommer ind, white er bare en placeholder.
            string[] masterCode = new string[] { "black", "blue", "yellow", "red" };
            string[] codeGuess = new string[] { "white", "white", "white", "white" };

            // spøger om farver og sender farverne ind på codeGuess listen/array. 
            Console.WriteLine("Guess the first color");
            codeGuess[0] = Console.ReadLine();
            Console.WriteLine("Guess the second color");
            codeGuess[1] = Console.ReadLine();
            Console.WriteLine("Guess the third color");
            codeGuess[2] = Console.ReadLine();
            Console.WriteLine("Guess the forth color");
            codeGuess[3] = Console.ReadLine();

            // kigger efter om arrays har de samme farver.
            if (masterCode[0] == codeGuess[0])
            {
                Console.WriteLine("first color is right");
            }
            else if (codeGuess[0] == masterCode[0])
            {

            }
            else
            {

            }




            {
                Console.WriteLine("first color is not " + codeGuess[0]);
            }
            if (masterCode[1] == codeGuess[1])
            {
                Console.WriteLine("correct the second color is " + codeGuess[1]);
            }
            else
            {
                Console.WriteLine("second color is not " + codeGuess[1]);
            }
            if (masterCode[2] == codeGuess[2])
            {
                Console.WriteLine("third color is right");
            }
            else
            {
                Console.WriteLine("third color is not " + codeGuess[2]);
            }
            if (masterCode[3] == codeGuess[3])
            {
                Console.WriteLine("forth color is right");
            }
            else
            {
                Console.WriteLine("forth color is not " + codeGuess[3]);
            }

        }
    }
}
