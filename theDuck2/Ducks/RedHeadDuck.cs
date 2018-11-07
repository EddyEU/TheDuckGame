using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theDuck2
{
    class RedHeadDuck :IDuck,IDisplayBehavior,ISwimBehavior
    {

       IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;

        public RedHeadDuck(IQuackBehavior quackBehavior, IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
        }
        public  void PerformQuack()
        {
            quackBehavior.PerformQuack();
        }

        public  void PerformFly()
        {
            flyBehavior.PerformFly();
        }

        public  void Swim()
        {
            Console.WriteLine("Nada");
        }

        public  void Display()
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
