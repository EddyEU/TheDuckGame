using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDuckGame.IspSolution.Ducks.Insterfaces;

namespace TheDuckGame
{
    class RubberDuck : Duck, IQuackable, IFlyable
    {
        public void Quack()
        {
            Console.WriteLine("El pato dice Quack");
        }

        public void Fly()
        {
            Console.WriteLine("El Pato Vuela");
        }
    }
}
