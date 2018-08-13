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
            string firstNameInput;

            Console.WriteLine("Contenstant's first name?");
            firstNameInput = Console.ReadLine();
            Console.WriteLine(" ");

            return firstNameInput;
        }

        public static string GetContestantLastName()
        {
            string lastNameInput;

            Console.WriteLine("Contenstant's last name?");
            lastNameInput = Console.ReadLine();
            Console.WriteLine(" ");

            return lastNameInput;
        }

        public static string GetContestantEmail()
        {
            string emailInput;


            Console.WriteLine("What is the Contenstant's email?");
            emailInput = Console.ReadLine();
            Console.WriteLine(" ");

            return emailInput;
        }

        public static void SweepstakeMenuOptions()
        {
            Console.WriteLine("Press [1] to register a contestant!");
        }
    }
}
