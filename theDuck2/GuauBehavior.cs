using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace theDuck2
{
    class GuauBehavior : IQuackBehavior
    {

        public void PerformQuack()
        {
            Console.WriteLine("Guauuuu as dog");
        }
    }
}
