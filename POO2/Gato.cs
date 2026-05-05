using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_encapsulamento
{
    
    public class Gato : Animal
    {
        public override void comer()
        {
            Console.WriteLine("Comeu sachê(Whiskas)!!!");
        }
        public override void emitirSom()
        {
            Console.WriteLine("MIAUUUUUUU!!🐈");
        }
    }
}