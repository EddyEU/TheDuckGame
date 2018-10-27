using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheDuckGame
{
    class ClientConsole1
    {
        static void Main(string[] args)
        {
            Duck patoPlastico = new RubberDuck();
            patoPlastico.Quack();
            patoPlastico.Swim();
            patoPlastico.Display();
            patoPlastico.Fly();
            
            Duck patoRojo = new RedheadDuck();
            patoRojo.Quack();
            patoRojo.Swim();
            patoRojo.Display();
            patoRojo.Fly();
            Console.ReadKey();

            
        }
    }
}
