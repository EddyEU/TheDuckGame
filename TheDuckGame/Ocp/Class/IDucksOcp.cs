using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuckGame.Ocp
{
    abstract class IDucksOcp
    {
        IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;
        public IDucksOcp(IQuackBehavior quackBehavior, IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
        }


        public abstract void PerformQuack();
        public abstract void PerforFly();
        public abstract void Swim();
        public abstract void Display();

    }
}
