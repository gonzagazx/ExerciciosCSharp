using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atv_POO
{
    public class Tecnico : Curso
    {
        public Tecnico(string NomeConstrutor, int HorasConstrutor) : base 
        (NomeConstrutor, HorasConstrutor)
        {
        }

        //Sobrescrevendo a informação do método abstrato
        public override double CalcularPreco()
        {
            return Horas * 20; // valor por hora
        }
    }
}