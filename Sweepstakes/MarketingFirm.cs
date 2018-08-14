using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        public void FirmMenu()
        {
            UserInterface.SweepstakesGoToCreator();
            CreateSweepstake();
            string input = UserInterface.MakeMoreSweepstakes();

            if (input.ToLower().Trim() == "y")
            {
                while (input.ToLower().Trim() == "y")
                {
                    CreateSweepstake();
                    input = UserInterface.MakeMoreSweepstakes();
                }
            }
            else if (input.ToLower().Trim() == "n")
            {
                return;
            }
            else
            {
                throw new ApplicationException("That input was not valid!");
            }
            UserInterface.GoToSweepstakesMenu();            
        }

        private void CreateSweepstake()
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            sweepstakes.Name = UserInterface.CreateSweepstakes();
            manager.InsertSweepstakes(sweepstakes);
        }
    }
}
