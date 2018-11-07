using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using theDuck2;

namespace theDuck2
{
    class Client
    {
        static void Main(string[] args)
        {
            IDuck patoRojo = new RedHeadDuck(new QuackSound(), new FlyWithWings());
            IDuck patoPlastico = new RubberDuck();
            IDuck patoMallar = new MallarDuck(new QuackSound(), new FlyNoWay());
            IDuck patoMudo = new MuteFlyDuck( new FlyWithWings());

            IDuck perro = new Perro(new GuauBehavior());


            IDuck[] arrayPatos = { patoRojo, patoPlastico, patoMallar, patoMudo, perro };
            IList<IDuck> listaPatos = new List<IDuck>(arrayPatos);
            foreach (IDuck pato in listaPatos)
            {
                pato.DoAction();
                Console.WriteLine("--------------------------");
            }
        }
    }
}
