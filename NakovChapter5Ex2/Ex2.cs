using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakovChapter5Ex2
{
    class Ex2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());

            if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a >= 0 && b >= 0 && c >= 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b < 0 && c >= 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b >= 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a >= 0 && b < 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b >= 0 && c >= 0)
            {
                Console.WriteLine("-");
            }
            else if (a >= 0 && b < 0 && c >= 0)
            {
                Console.WriteLine("-");
            }
            else if (a >= 0 && b >= 0 && c < 0)
            {
                Console.WriteLine("-");
            }
        }
    }
}
