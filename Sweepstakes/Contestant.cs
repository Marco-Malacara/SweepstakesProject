using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNumber;
        public Contestant()
        {
            firstName = null;
            lastName = null;
            email = null;
            registrationNumber = 0;
        }

        public Contestant ContestantInfo()
        {
            Contestant contestant = new Contestant();
            registrationNumber++;
            contestant.firstName = UserInterface.GetContestantFirstName();
            contestant.lastName = UserInterface.GetContestantLastName();
            contestant.email = UserInterface.GetContestantEmail();
            contestant.registrationNumber = registrationNumber;
            return contestant;
        }
    }
}
