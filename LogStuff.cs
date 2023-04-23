using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_premium_thing
{
    internal class Logs
    {

        internal static void Log(string message, object arg0, object arg1)
            {

                Console.Write("[", Console.ForegroundColor = ConsoleColor.Red);
                Console.Write("Logger", Console.ForegroundColor = ConsoleColor.Gray);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("] ", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                Console.Write(message, arg0, arg1);

            }

            internal static void Log(string message, object arg0)
            {
                Console.Write("[", Console.ForegroundColor = ConsoleColor.Red);
                Console.Write("Logger", Console.ForegroundColor = ConsoleColor.Gray);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("] ", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(message, arg0);
            }

            internal static void Log(string message)
            {
                Console.Write("[", Console.ForegroundColor = ConsoleColor.Red);
                Console.Write("Premium-Logger", Console.ForegroundColor = ConsoleColor.Gray);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("] ", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor();
                Console.Write(message);
            }

            internal static void badge()
            {

                Console.Write("        ☑️ " + "\n", Console.ForegroundColor = ConsoleColor.Cyan);

            }

        }

    }