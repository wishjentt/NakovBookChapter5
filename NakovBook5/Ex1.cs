using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakovBook5
{
    class Ex1
    {
        static void Main(string[] args)
        {
            int biggerNum = int.Parse(Console.ReadLine());
            int smallerNum = int.Parse(Console.ReadLine());

            if(biggerNum > smallerNum)
            {
                biggerNum = smallerNum;

                Console.WriteLine("Bigger Num is: {0}" , biggerNum);
            }
        }
    }
}
