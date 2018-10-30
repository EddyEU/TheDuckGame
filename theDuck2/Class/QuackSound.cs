using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theDuck2
{
    public class QuackSound : IQuackBehavior
    {


        void IQuackBehavior.PerformQuack()
        {
            Console.WriteLine("Dice Quack");
        }
    }
}
