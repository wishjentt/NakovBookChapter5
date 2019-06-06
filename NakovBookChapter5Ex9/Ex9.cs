using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakovBookChapter5Ex9
{
    class Ex9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            sbyte first = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter second number: ");
            sbyte second = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter third number: ");
            sbyte third = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            sbyte fourth = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            sbyte fifth = Convert.ToSByte(Console.ReadLine());

            if (first + second == 0)
            {
                Console.WriteLine("{0}+ {1} = 0", first, second);
            }
            else if (first + third == 0)
            {
                Console.WriteLine("{0}+ {1} = 0", first, third);
            }
            else if (first + fourth == 0)
            {
                Console.WriteLine("{0}+ {1} = 0", first, fourth);
            }
            else if (first + fifth == 0)
            {
                Console.WriteLine("{0}+ {1} = 0", first, fifth);
            }

            else if (second + third == 0)
            {
                Console.WriteLine("{0}+ {1} = 0", second, third);
            }
            else if (second + fourth == 0)
            {
                Console.WriteLine("{0}+ {1} = 0", second, fourth);
            }
            else if (second + fifth == 0)
            {
                Console.WriteLine("{0}+ {1} = 0", second, fifth);
            }
            else if (third + fourth == 0)
            {
                Console.WriteLine("{0}+ {1} = 0", third, fourth);
            }
            else if (third + fifth == 0)
            {
                Console.WriteLine("{0}+ {1} = 0", third, fifth);
            }
            else if (fourth + fifth == 0)
            {
                Console.WriteLine("{0}+ {1} = 0", fourth, fifth);
            }

            else if (first + second + third == 0)
            {
                Console.WriteLine("{0}+ {1}+ {2} = 0", first, second, third);
            }
            else if (first + second + fourth == 0)
            {
                Console.WriteLine("{0}+ {1}+ {2} = 0", first, second, fourth);
            }

            else if (first + second + fifth == 0)
            {
                Console.WriteLine("{0}+ {1}+ {2} = 0", first, second, fifth);
            }
            else if (first + third + fourth == 0)
            {
                Console.WriteLine("{0}+ {1}+ {2} = 0", first, third, fourth);
            }
            else if (first + third + fifth == 0)
            {
                Console.WriteLine("{0}+ {1}+ {2} = 0", first, third, fifth);
            }
            else if (second + third + fourth == 0)
            {
                Console.WriteLine("{0}+ {1}+ {2} = 0", second, third, fourth);
            }
            else if (second + third + fifth == 0)
            {
                Console.WriteLine("{0}+ {1}+ {2} = 0", second, third, fifth);
            }
            else (third + fourth + fifth == 0)
            {
                Console.WriteLine("{0}+ {1}+ {2} = 0", third, fourth, fifth);
            }
            Console.ReadLine();
        }
    }
}
