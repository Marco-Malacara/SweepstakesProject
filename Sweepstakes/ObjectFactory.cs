using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class ObjectFactory
    {
        public ISweepstakesManager SetManagment(ISweepstakesManager manager)
        {
            string input = UserInterface.ChooseManagmentTool();
            switch (input.ToLower().Trim())
            {
                case "queue":
                    return manager = new SweepstakesQueueManager();
                case "stack":
                    return manager = new SweepstakesStackManager();
                default:
                    throw new ApplicationException("Input was not a valid sweepstakes managment tool.");
            }
        }
    }
}
