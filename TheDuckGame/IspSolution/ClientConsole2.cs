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
            DuckIsp patoPlastico = new RubberDuckIsp();
            patoPlastico.Display();
            patoPlastico.Swim();
            DuckIsp patoCabezaRoja = new RedheadDuckIsp();
            patoCabezaRoja.Swim();
            patoCabezaRoja.Display();



        }
    }
}
