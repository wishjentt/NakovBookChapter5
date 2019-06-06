using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakovBookChapter5Ex4
{
    class Ex4
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            if(firstNumber>secondNumber && firstNumber> thirdNumber && secondNumber>thirdNumber)
            {
                
                Console.WriteLine("{0}, {1}, {2}", firstNumber, secondNumber,thirdNumber);

            }
            else if(secondNumber > firstNumber && secondNumber > thirdNumber && firstNumber > thirdNumber)
            {
                
                Console.WriteLine("{0},{1},{2}", secondNumber, firstNumber, thirdNumber );
            }
            else if(thirdNumber > firstNumber && thirdNumber > secondNumber && secondNumber>firstNumber)
            {
                
                Console.WriteLine("{0},{1},{2}", thirdNumber, secondNumber, firstNumber);
            }

            else if(firstNumber>secondNumber && firstNumber > thirdNumber && thirdNumber > secondNumber)
            {
                Console.WriteLine("{0},{1},{2}", firstNumber,thirdNumber, secondNumber);
            }

            else if (secondNumber > firstNumber && secondNumber > thirdNumber && thirdNumber >firstNumber)
            {

                Console.WriteLine("{0},{1},{2}", secondNumber, thirdNumber, firstNumber);
            }

        }
    }
}
