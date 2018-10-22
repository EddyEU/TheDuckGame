using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDuckGame.IspSolution.Ducks.Insterfaces;

namespace TheDuckGame
{
    class RubberDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("El pato No dice Quack");
        }

        public override void Fly()
        {
            Console.WriteLine("El Pato No  Vuela");
        }
    }
}
