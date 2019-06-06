using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakovBookChapter5Ex8
{
    class Ex8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value: 0-int, 1-double, 2-string");
            int intVar = int.Parse(Console.ReadLine());

            switch (intVar)
            {
                case 0:
                    Console.WriteLine("Enter int Value:");
                    intVar = Int32.Parse(Console.ReadLine());
                    intVar++;
                    Console.WriteLine("Int +1 = {0}", intVar);
                    break;
                case 1:
                    Console.WriteLine("Enter double Value:");
                   double doubleVar = Double.Parse(Console.ReadLine());
                    doubleVar++;
                    Console.WriteLine("Double +1 = {0}", doubleVar);
                    break;
                case 2:
                    Console.WriteLine("Enter string Value:");
                    string stringVar = Console.ReadLine();
                   
                    Console.WriteLine("{0}" + " " + "*" , stringVar);
                    break;
                default:
                    Console.WriteLine("Invalid enter");
                    break;
            }
        }
    }
}
