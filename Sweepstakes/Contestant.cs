using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string email { get; set; }
        
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
