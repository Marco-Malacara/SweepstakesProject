using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        readonly ISweepstakesManager manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        public MarketingFirm()
        {

        }
        public void FirmMenu()
        {
            //string input = UserInterface.ChooseManagmentTool();
            //UserInterface.GoToSweepstakesMenu();
            GetSweepstakeManager(manager);
        }

        public ISweepstakesManager GetSweepstakeManager(ISweepstakesManager manager)
        {
            ObjectFactory obj = new ObjectFactory();
            return obj.SetManagment(manager);
        }

        private void CreateSweepstake()
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            sweepstakes.Name = UserInterface.CreateSweepstakes();
        }
    }
}
