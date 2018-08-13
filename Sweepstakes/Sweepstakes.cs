using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> dictionary = new Dictionary<int, Contestant>();
        public void RegisterContestant(Contestant contestant)
        {
            int registrationNumber = dictionary.Count();
            dictionary.Add(registrationNumber, contestant);
        }

        public void CreateContestant()
        {
            Contestant contestant = new Contestant();
            contestant = contestant.ContestantInfo();
            RegisterContestant(contestant);
        }
    }
}
