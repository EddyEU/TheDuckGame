using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuckGame.Ocp2v
{
    class MallarDuckOcp2 : IDucksOcp2
    {
        IQuackBehavior2 quackBehavior = new QuackOcp2();
        IFlyBehavior2 flyBehavior = new FlyWithWings2();
        public override void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public override void PerforFly()
        {
            flyBehavior.Fly();
        }

          public override void Swim()
        {
            Console.WriteLine("Pato nada");
        }

        public override void Display()
        {
            Console.WriteLine("Pato se muestra");
        }
    }
    
}
