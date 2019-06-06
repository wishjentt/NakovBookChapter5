using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakovBookChapter5Ex3
{
    class Ex3
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNubmber = int.Parse(Console.ReadLine());

            if(firstNumber>secondNumber && firstNumber > thirdNubmber)
            {
                Console.WriteLine("{0} is greatest number" , firstNumber);
            }
            else if(secondNumber > firstNumber && secondNumber > thirdNubmber)
            {
                Console.WriteLine("{0} is greatest number", secondNumber);
            }
            else if (thirdNubmber > firstNumber && thirdNubmber > secondNumber)
            {
                Console.WriteLine("{0} is greatest number", thirdNubmber);
            }
            else
            {
                Console.WriteLine("All numbers are equal") ;
            }
        }
    }
}
