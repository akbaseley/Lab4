using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Baseley_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Let's refresh your Geometry!!");

            while (true)
            {
                //input
                int UserNumber = GetNumber("Please enter a number!");


                //Process & Output
                Console.Write($"{"Number",-10}");
                Console.Write($"{"Squared",-10}");
                Console.WriteLine("Cubed");

                Console.Write($"{"******",-10}");
                Console.Write($"{"*******",-10}");
                Console.WriteLine("*****");

                for (int i = 1; i <= UserNumber; i++)
                {
                    int number = i;
                    int squared = i * i;
                    int cubed = squared * i;

                    Console.Write($"{number,-10}");
                    Console.Write($"{squared,-10}");
                    Console.WriteLine($"{cubed}");
                }


                //Continue?
                if (UserContinue() == false)
                {
                    break;
                }
            }
        }
        public static int GetNumber(string Message)
        {
            Console.WriteLine(Message);
            int UserNumber = int.Parse(Console.ReadLine());
            return UserNumber;
        }
        public static bool UserContinue()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Would you like to continue? y/n");
            String UserContinue = Console.ReadLine();

            while (true)
            {

                if (UserContinue.ToLower() != "y" && UserContinue.ToLower() != "n")
                {
                    Console.WriteLine("What was that?  Would you like to continue? y/n");
                    UserContinue = Console.ReadLine();
                }

                else if (UserContinue.ToLower() == "n")
                {
                    Console.WriteLine("Okay!  See you next time!");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
