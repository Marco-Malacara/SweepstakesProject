using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> dictionary;
        private string name;

        public string Name { get => name; set => name = value; }

        public Sweepstakes()
        {
            dictionary = new Dictionary<int, Contestant>();
            name = null;
        }

        public void SweepstakesMenu()
        {
            string input = UserInterface.SweepstakeMenuOptions();

            switch (input)
            {
                case "1":
                    CreateContestant();
                    break;
            }
        }

        //public string _Sweepstakes(string name)
        //{
        //    
        //}

        private void RegisterContestant(Contestant contestant)
        {
            int registrationNumber = dictionary.Count();
            dictionary.Add(registrationNumber, contestant);
        }
        private void CreateContestant()
        {
            Contestant contestant = new Contestant();
            contestant = contestant.ContestantInfo();
            RegisterContestant(contestant);
            Console.Clear();
        }
    }
}
