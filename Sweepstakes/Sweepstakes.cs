using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> dictionary = new Dictionary<int, Contestant>();

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

        //public void SweepstakeManagement()
        //{
        //    string input = UserInterface.ChooseManagmentTool();
        //    MarketingFirm firm = new MarketingFirm();
        //    iSweepstakesManager managmentType = firm.ChooseManagment(input);
        //}

        //public string Sweepstakes(string name)
        //{

        //}
        private void CreateSweepstake()
        {
            string input = UserInterface.CreateSweepstakes();
            //Sweepstakes(input);
        }

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
