using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace theDuck2
{
    
    class MuteFlyDuck : IDucks
    
    {

        private IFlyBehavior flyBehavior;

        public MuteFlyDuck(IFlyBehavior behavior) {
            this.flyBehavior = behavior;
        }

        public override void PerformQuack()
        {
            throw new NotImplementedException();
        }

        public override void PerforFly()
        {
            throw new NotImplementedException();
        }

        public override void Swim()
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
