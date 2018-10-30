using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theDuck2
{
    class FlyNoWay : IFlyBehavior
    {

        public  void Fly()
        {
            Console.WriteLine("Este pato no puede volar.");
        }
    }
}
