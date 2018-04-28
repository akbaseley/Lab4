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
            bool Repeat = true;    
            while (Repeat)
            {
                //input
                int UserNumber = GetNumber("Please enter a number!");


                //Process & Output
                Console.WriteLine($"{"Number",-10}{"Squared",-10}{"Cubed", -10}");

                Console.WriteLine($"{"******",-10}{"*******",-10}{"*****", -10}");


                for (int i = 1; i <= UserNumber; i++)
                {
                    int number = i;
                    int squared = i * i;
                    int cubed = squared * i;

                    Console.WriteLine($"{number,-10}{squared,-10}{cubed, -10}");

                    //Continue
                    Repeat = UserContinue();                                 
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

            while (UserContinue.ToLower() != "y" && UserContinue.ToLower() != "n")
            {
                Console.WriteLine("What was that?  Would you like to continue? y/n");
                UserContinue = Console.ReadLine();
            }

            while (true)
            {
                if (UserContinue.ToLower() == "n")
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
