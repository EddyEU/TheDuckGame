using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDuckGame.IspSolution;

namespace TheDuckGame
{
    class ClientConsole2
    {
        static void Main(string[] args)
        {
            RubberDuckIsp patoPlastico = new RubberDuckIsp();
            patoPlastico.Display();
            patoPlastico.Swim();
            
            RedheadDuckIsp patoCabezaRoja = new RedheadDuckIsp();
            patoCabezaRoja.Swim();
            patoCabezaRoja.Display();
            patoCabezaRoja.Quack();
            patoCabezaRoja.Fly();
            Console.ReadKey();


        }
    }
}
