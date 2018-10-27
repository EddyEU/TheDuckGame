using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuckGame.Ocp
{
    class QuackOcp : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("El pato dice Quack");
        }
    }
}
