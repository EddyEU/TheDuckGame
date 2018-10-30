using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theDuck2
{
    class FlyWithWings : IFlyBehavior
    {
        public  void PerformFly()
        {
            Console.WriteLine("El pato vuela con las alas.");
        }
    }
}
