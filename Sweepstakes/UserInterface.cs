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
            Console.WriteLine("Welcome the the sweepstakes application manager.");
            Console.WriteLine("First establish which Sweepstakes Mangment you'd perfer to use.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Input [Q] for a Queue Manger.");
            Console.WriteLine("");
            Console.WriteLine("Or");
            Console.WriteLine("");
            Console.WriteLine("Input [S] for a Stack Manager.");
            Console.WriteLine("");
            string input = Console.ReadLine();
            Console.Clear();
            return input;
        }
        
        public static void SweepstakesGoToCreator()
        {
            Console.WriteLine("Now that we have a sweepstake manager lets create some sweepstakes!");
            Console.WriteLine("Press [ENTER] to start creating your sweepstakes!");
            Console.ReadLine();
            Console.Clear();
        }
        
        public static string MakeMoreSweepstakes()
        {
            Console.WriteLine("'Sweepstake was succesfully added!'");
            Console.WriteLine("");
            Console.WriteLine("Do you want to make another sweepstake?");
            Console.WriteLine("");
            Console.WriteLine("Input [Y] for yes.");
            Console.WriteLine("");
            Console.WriteLine("Or");
            Console.WriteLine("");
            Console.WriteLine("Input [N] for no.");
            string input = Console.ReadLine();
            Console.Clear();
            return input;
        }

        public static void GoToSweepstakesMenu()
        {
            Console.WriteLine("Now that the manager has all your Sweepstakes lets add some contestant's,");
            Console.WriteLine("its not a Sweepstake without any contestants!");
            Console.WriteLine("Press [ENTER] to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static string AddMoreContestants()
        {
            Console.WriteLine("'Contestant was succefully added!'");
            Console.WriteLine("");
            Console.WriteLine("Would you like to add another contestant?");
            Console.WriteLine("");
            Console.WriteLine("Input [Y] for yes.");
            Console.WriteLine("");
            Console.WriteLine("Or");
            Console.WriteLine("");
            Console.WriteLine("Input [N] for no.");
            string input = Console.ReadLine();
            Console.Clear();
            return input;
        }

        public static string ChooseSpecificSweepstake()
        {
            Console.WriteLine("What sweepstake would you like to go to?");
            string input = Console.ReadLine();
            return input;
        }
    }
}
