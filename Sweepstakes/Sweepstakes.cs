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
                case "2":
                    //Print Contestant Info
                    break;
            }
        }

        private void RegisterContestant(Contestant contestant)
        {
            int registrationNumber = dictionary.Count();
            dictionary.Add(registrationNumber, contestant);
            PrintContestantInfo(contestant);
        }
        private void CreateContestant()
        {
            Contestant contestant = new Contestant();
            contestant = contestant.ContestantInfo();
            RegisterContestant(contestant);
            Console.Clear();
        }

        private void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant);
        }

        private void RetrieveContestantInfo()
        {
           
        }

        //public string _Sweepstakes(string name)
        //{
        //    
        //}
    }
}
