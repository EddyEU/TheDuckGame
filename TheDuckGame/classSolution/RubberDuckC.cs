using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuckGame.classSolution.Ducks.Interfaces
{
    public  class RubberDuckC : IDucksGroup, IQuackC
    {


        public void Quack()
        {
            Console.WriteLine("dice quack");
        }
    }
}
