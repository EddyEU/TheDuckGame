using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theDuck2
{
    class RubberDuckOcp : IDucks,IDisplayBehavior,ISwimBehavior
    {

        public void DoAction()
        {
            Swim();
            Display();
        }

        public void Swim()
        {
            Console.WriteLine("El pato nada");
        }

        public void Display()
        {
            Console.WriteLine("El pato se muestra");
        }
    }
}
