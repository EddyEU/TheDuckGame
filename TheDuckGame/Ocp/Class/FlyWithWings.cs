using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuckGame.Ocp
{
    class FlyWithWings : IFlyBehavior
    {
        public  void Fly()
        {
            Console.WriteLine("El pato vuela con las alas.");
        }
    }
}
