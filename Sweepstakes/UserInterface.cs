using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static string GetContestantFirstName()
        {
            Console.WriteLine("Contenstant's first name?");
            string firstNameInput = Console.ReadLine();
            Console.WriteLine(" ");

            return firstNameInput;
        }

        public static string GetContestantLastName()
        {
            Console.WriteLine("Contenstant's last name?");
            string lastNameInput = Console.ReadLine();
            Console.WriteLine(" ");

            return lastNameInput;
        }

        public static string GetContestantEmail()
        {
            Console.WriteLine("What is the Contenstant's email?");
            string emailInput = Console.ReadLine();
            Console.WriteLine(" ");

            return emailInput;
        }

        public static string SweepstakeMenuOptions()
        {
            Console.WriteLine("Press [1] to register a contestant!");
            string input = Console.ReadLine();
            Console.Clear();
            return input;
        }

        public static string CreateSweepstakes()
        {
            Console.WriteLine("What is the name of the sweepstake?");
            string sweepstake = Console.ReadLine();
            Console.Clear();
            return sweepstake;
        }

        public static string ChooseManagmentTool()
        {
            Console.Clear();
            Console.WriteLine("Which type of sweepstake managment would you like to use?");
            Console.WriteLine("Input Queue for a Queue Manger.");
            Console.WriteLine("Or");
            Console.WriteLine("Input Stack for a Stack Manager.");
            string input = Console.ReadLine();
            Console.Clear();
            return input;
        }
    }
}
