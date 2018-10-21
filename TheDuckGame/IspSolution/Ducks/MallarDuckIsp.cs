using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDuckGame.IspSolution;
using TheDuckGame.IspSolution.Ducks.Insterfaces;

namespace TheDuckGame
{
    class MallarDuckIsp : DuckIsp, IQuackable, IFlyable
    {

        public void Quack()
        {
            Console.WriteLine("El pato dice Quack");
        }

        public void Fly()
        {
            Console.WriteLine("El Pato Vuela");
        }

        public void Swim()
        {
            Console.WriteLine("El Pato Nada");
        }

        public void Display()
        {
            Console.WriteLine("El Pato Se Muestra");
        }
    }
}
