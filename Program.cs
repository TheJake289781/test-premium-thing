using System;
using System.Diagnostics.Tracing;
using System.Security.Cryptography;
using test_premium_thing;
using static System.Net.Mime.MediaTypeNames;

namespace Test_Prem
{

    class Tester
    {

        public static void Main(string[] args)
        {

            string get = "What Do You Want: ";

            Console.Write("Welcome in my test program for testing: ");
            Console.Write("Premium ", Console.ForegroundColor = ConsoleColor.Green); Console.ResetColor();
            Console.Write("things" + "\n"); Console.ResetColor();

            Console.Write("Get Premium: "); Console.ForegroundColor = ConsoleColor.Cyan;
            get = Console.ReadLine();

            if (get == "yes")
            {

                Console.Write("You Got Prem!" + "\n", Console.ForegroundColor = ConsoleColor.Green);
                Console.Write("Acces To: " + "\n", Console.ForegroundColor = ConsoleColor.Red); Console.ResetColor();
                Console.Write("1. Logs(Adds Logs)(write Logs)" + "\n");
                Console.Write("2. premium badge(kinda bad ig)(write badge)" + "\n");
                Console.Write("3. Calculator(write calculator)" + "\n");
                Console.Write("4. Beta Things(yeh)(write beta things)" + "\n");
                Console.Write("5. Fake Virus(write FV)" + "\n");
                Console.ResetColor();
                Console.Write("What Do You Want: "); string test = Console.ReadLine();
                if (test == "Logs")
                {

                    Logs.Log("Clearing", Console.ForegroundColor = ConsoleColor.Red);
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.Write("1. Logs(Adds Logs)(write Logs)" + "\n");
                    Console.Write("2. premium badge(kinda bad ig)(write badge)" + "\n");
                    Console.Write("3. Calculator(write calculator)" + "\n");
                    Console.Write("4. Beta Things(yeh)(write beta things)" + "\n");
                    Console.Write("5. Fake Viru(write FV)");
                    Logs.Log("What Do You Want: "); string add2 = Console.ReadLine();
                    if (add2 == "badge")
                    {

                        Logs.Log("Adding Please Wait" + "\n");
                        Thread.Sleep(500); Logs.Log("Added Badge: (badge:)"); Logs.badge();
                        Logs.Log("exit");

                    }
                    else if (add2 == "beta things")
                    {

                        Logs.Log("Beta Things" + "..." + "\n", Console.ForegroundColor = ConsoleColor.Magenta);
                        Logs.Log("all beta things will be added here for you to test out!" + "\n");

                        Logs.Log("BT.1 = textbook 152 lines(press 1 to get): "); string BT1 = Console.ReadLine();

                        if (BT1 == "1")
                        {

                            NoteBooks.LogNoteBook();

                        }
                    } else if (add2 == "calculator")
                    {

                        calculator.Cal();

                    } else if (add2 == "FV")
                    {

                        VirusL.FakeVirus.Virus();

                    }
                }
                else if (test == "badge")
                {

                    Logs.Log("Adding Please Wait" + "\n");
                    Thread.Sleep(500); Logs.Log("Added Badge: (badge:)"); Logs.badge();

                }
                else if (test == "beta things")
                {

                    Logs.Log("Beta Things" + "..." + "\n", Console.ForegroundColor = ConsoleColor.Magenta);
                    Logs.Log("all beta things will be added here for you to test out!" + "\n");

                    Logs.Log("BT.1 = textbook 152 lines(press 1 to get): "); string BT1 = Console.ReadLine();

                    if (BT1 == "1")
                    {

                        NoteBooks.LogNoteBook();

                    } 

                } else if (test == "calculator")
                {

                    calculator.Cal();

                } else if (test == "FV")
                {

                    VirusL.FakeVirus.Virus();

                }
            }

            else if (get == "no")
            {
                Console.ResetColor();
                Console.Write("You Are A Basic Member" + "\n");
                Console.ResetColor();
                Console.Write("Acces To: ", Console.ForegroundColor = ConsoleColor.Red);
                Console.ResetColor(); Console.Write(@"
1. notebook: 100 lines((Beta)write note book)
2. calculator(write calculator)
3. Fake Virus(write FV)");
                Console.Write("What Do You Want: "); string add = Console.ReadLine();

                if (add == "note book")
                {

                    NoteBooks.NoneLogNotBook();

                }
                else if (add == "calculator")
                {

                    Console.Write("calculator" + "\n", Console.ForegroundColor = ConsoleColor.Blue);

                    calculator.Cal();

                } else if (add == "FV")
                {

                    Console.Clear();
                    VirusL.FakeVirus.Virus();
                    

                }


            }


            Console.ReadKey();

        }
    }
}