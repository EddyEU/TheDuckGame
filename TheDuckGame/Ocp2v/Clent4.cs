using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDuckGame.Ocp2v
{
    class Clent4
    {
        static void Main(string[] args)
        {
            IDucksOcp2 patoPlastico = new RubberDuckOcp2();
            IDucksOcp2 patoMallar = new MallarDuckOcp2();

            IDucksOcp2[] arrayPatos = {  patoPlastico, patoMallar };
            IList<IDucksOcp2> listaPatos = new List<IDucksOcp2>(arrayPatos);
            foreach (IDucksOcp2 pato in listaPatos)
            {
                pato.Display();
                pato.Swim();
                pato.PerformQuack();
                pato.PerforFly();
                Console.WriteLine("-----------------------------------");
            }

            Console.ReadKey();
        }
    }
}
