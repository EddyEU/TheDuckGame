using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace theDuck2
{
    class Perro :  IDuck
    {
        private IQuackBehavior guauBehavior;

        public Perro(IQuackBehavior guauBehavior) {
            this.guauBehavior = guauBehavior;
        }
        public void DoAction()
        {
            this.guauBehavior.PerformQuack();
        }
    }
}
