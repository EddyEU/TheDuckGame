using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace theDuck2
{
    
    class MuteFlyDuck : IDuck,IFlyBehavior
    
    {

        private IFlyBehavior flyBehavior;

        public MuteFlyDuck(IFlyBehavior behavior) {
            this.flyBehavior = behavior;
        }


        public void PerformFly()
        {
            flyBehavior.PerformFly();
        }

        public void DoAction()
        {
            PerformFly();
        }
    }
}
