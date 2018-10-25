using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDuckGame.InmediateSolution.Ducks;

namespace TheDuckGame
{
    class ClientConsole1
    {
        static void Main(string[] args)
        {
            Duck patoPlastico = new RubberDuck();
            Duck patoRojo = new RedheadDuck();
            Duck patoJugete = new ToyDuck();
           
            List<Duck> patos = new List<Duck>();
            patos.Add(patoPlastico);
            patos.Add(patoRojo);
            patos.Add(patoJugete);
            foreach(Duck patoMostrar in patos){
                patoMostrar.Quack();
                patoMostrar.Swim();
                patoMostrar.Display();
                patoMostrar.Fly();
            }
            Console.ReadKey();
            
        }
    }
}
