using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuckGame.Ocp2v
{
    class QuackOcp2 : IQuackBehavior2
    {
        public void Quack()
        {
            Console.WriteLine("El pato dice Quack");
        }
    }
}
