using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuckGame.Ocp
{
    class MallarDuckOcp:IDucksOcp
    {
        IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;
        public MallarDuckOcp(IQuackBehavior quackBehavior, IFlyBehavior flyBehavior)
            : base(quackBehavior, flyBehavior) //Bar's constructor's must call Foo's parameterless constructor.
        {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
        }
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
            Console.WriteLine("Nada");
        }

        public override void Display()
        {
            Console.WriteLine("Se muestra");
        }
    }
}
