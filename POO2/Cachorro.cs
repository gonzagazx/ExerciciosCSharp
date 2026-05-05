using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_encapsulamento
{
    public class Cachorro : Animal
    {
        public override void comer()
        {
            Console.WriteLine("Comeu biscoitos!!!");
        }
        // override = Redefinir um métdo herdado
        public override void emitirSom()
        {
            Console.WriteLine("Au Au!!!!!");
        }
    }
}