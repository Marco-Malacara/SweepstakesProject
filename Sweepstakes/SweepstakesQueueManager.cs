using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> Queue = new Queue<Sweepstakes>();

        public Sweepstakes GetSweepstakes()
        {
            throw new ApplicationException("");
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Queue.Enqueue(sweepstakes);
        }
    }
}
