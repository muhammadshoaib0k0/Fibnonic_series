using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibnonic_series // 0 , 1 ,1 , 2 , 3 , 5 , 8 , 13 ....
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=0 , num2=1 , num3 , range;
            Console.WriteLine("enter the range : ");
            range = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1 + " ");
            Console.Write(num2+ " ");
            // LOGIC                    ---------------------- IS HERE --------------------------------
            while (range > 1)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
                range--;
            }
            Console.ReadLine();
        }
    }
}
