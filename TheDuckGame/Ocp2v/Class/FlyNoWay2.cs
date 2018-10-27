using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuckGame.Ocp2v
{
    class FlyNoWay2 : IFlyBehavior2
    {
        public void Fly()
        {
            Console.WriteLine("Este pato no puede volar.");
        }
    }
}
