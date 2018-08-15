using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        private string firstName;
        private string lastName;
        private string email;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }

        public Contestant ContestantInfo()
        {
            Contestant contestant = new Contestant();
            contestant.firstName = UserInterface.GetContestantFirstName();
            contestant.lastName = UserInterface.GetContestantLastName();
            contestant.email = UserInterface.GetContestantEmail();
            return contestant;
        }
    }
}
