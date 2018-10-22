using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuckGame
{
    class Duck
    {
        public virtual void Quack() {
            Console.WriteLine("El pato dice Quack");
        }
        public void Swim()
        {
            Console.WriteLine("El pato Nada");
        }
        public void Display()
        {
            Console.WriteLine("El pato se muestra");
        }
        public virtual void Fly()
        {
            Console.WriteLine("El pato Vuela");
        }
    }
}
