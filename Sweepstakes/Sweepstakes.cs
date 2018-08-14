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
        private int registrationNumber;

        public string Name { get => name; set => name = value; }
        public int RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }

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
                    AddContestantMenu();
                    break;
                case "2":
                    RetrieveContestantInfo();
                    break;
            }
        }

        public void AddContestantMenu()
        {
            CreateContestant();

            string input = UserInterface.AddMoreContestants();

            if (input.ToLower().Trim() == "y")
            {
                while (input.ToLower().Trim() == "y")
                {
                    CreateContestant();
                    input = UserInterface.MakeMoreSweepstakes();
                }
            }
            else if (input.ToLower().Trim() == "n")
            {
                SweepstakesMenu();
            }
            else
            {
                throw new ApplicationException("That input was not valid!");
            }
        }

        private void RegisterContestant(Contestant contestant)
        {
            RegistrationNumber = dictionary.Count();
            dictionary.Add(RegistrationNumber, contestant);
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
            
        }

        private void RetrieveContestantInfo()
        {
            foreach (KeyValuePair<int, Contestant> contastant in dictionary)
            {
                Console.WriteLine("First Name: {0} ", contastant.Value.FirstName);
                Console.ReadLine();
            }
        }

        //public string _Sweepstakes(string name)
        //{
        //    
        //}
    }
}
