using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        public iSweepstakesManager ChooseManagment(string input)
        {
            switch (input.ToLower())
            {
                case "queue":
                    return new SweepstakesQueueManager();
                case "stack":
                    return new SweepstakesStackManager();
                default:
                    throw new ApplicationException("Input was not a valid sweepstakes managment tool.");
            }
        }
    }
}
