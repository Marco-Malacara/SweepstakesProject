using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class ObjectFactory
    {
        public ISweepstakesManager SetManagment()
        {
            string input = UserInterface.ChooseManagmentTool();
            switch (input.ToLower().Trim())
            {
                case "q":
                    return new SweepstakesQueueManager();
                case "s":
                    return new SweepstakesStackManager();
                default:
                    throw new ApplicationException("Input was not a valid sweepstakes managment tool.");
            }
        }
    }
}
