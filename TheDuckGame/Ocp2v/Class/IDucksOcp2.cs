using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuckGame.Ocp2v
{
    abstract class IDucksOcp2
    {
        public abstract void PerformQuack();
        public abstract void PerforFly();
        public abstract void Swim();
        public abstract void Display();
    }
}
