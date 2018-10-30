using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theDuck2
{
    class RedHeadDuckOcp :IDucks,IFlyBehavior,IDisplayBehavior,IQuackBehavior,ISwimBehavior
    {

       IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;
        public RedHeadDuckOcp(IQuackBehavior quackBehavior, IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
        }
        public override void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public override void PerformFly()
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

        public void DoAction()
        {
            Display();
            Swim();
            PerformQuack();
            PerformFly();

        }
    }
}
