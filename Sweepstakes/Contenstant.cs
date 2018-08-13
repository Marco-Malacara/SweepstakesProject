using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contenstant
    {
        public string firstName;
        public string lastName;
        public string email;
        public string registration;

        public Contenstant()
        {
            firstName = null;
            lastName = null;
            email = null;
            registration = null;
        }

        public void ContenstantRegistration()
        {
            UserInterface.Registration();
        }
    }
}
