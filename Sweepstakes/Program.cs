using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectFactory obj = new ObjectFactory();
            ISweepstakesManager manager =  obj.SetManagment();
            MarketingFirm marketing = new MarketingFirm(manager);
            marketing.FirmMenu();
            Sweepstakes sweep = new Sweepstakes(UserInterface.SweepstakeMenuOptions());
            sweep.SweepstakesMenu();
            Console.ReadLine();
        }
    }
}
