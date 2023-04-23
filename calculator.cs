using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_premium_thing
{
    internal class calculator
    {

        internal static void Cal()
        {

            string sign = "enter a sign --> ";

            Console.Write("enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(sign);
            sign = Convert.ToString(Console.ReadLine());

            Console.Write("enter a number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (sign == "+")
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(num1 + num2);

            }

            else if (sign == "-")
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(num1 - num2);

            }

            else if (sign == ":")
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(num1 / num2);

            }

            else if (sign == "x")
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(num1 * num2);

            }

        }

    }
}
