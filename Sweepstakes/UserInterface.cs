using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static void Registration()
        {
            Contenstant contenstant = new Contenstant();

            string firstNameInput;
            string lastNameInput;
            string emailInput;
            string registartaionNumberInput;

            Console.WriteLine("Contenstant's first name?");
            firstNameInput = Console.ReadLine();
            contenstant.firstName = firstNameInput;

            Console.WriteLine("Contenstant's last name?");
            lastNameInput = Console.ReadLine();
            contenstant.lastName = lastNameInput;

            Console.WriteLine("What is the Contenstant's email?");
            emailInput = Console.ReadLine();
            contenstant.email = emailInput;

            Console.WriteLine("What is the Contenstant's registration number?");
            registartaionNumberInput = Console.ReadLine();
            contenstant.registration = registartaionNumberInput;
        }
    }
}
