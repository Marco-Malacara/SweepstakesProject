using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            string input = UserInterface.ChooseSpecificSweepstake();

            for (int i = 0; i < stack.Count(); i++)
            {
                if (input.ToLower().Trim() == stack.ElementAt(i).Name.ToLower().Trim())
                {
                    return stack.ElementAt(i);
                }
            }
            throw new ApplicationException("No sweepstake with that name exist!");
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
    }
}
