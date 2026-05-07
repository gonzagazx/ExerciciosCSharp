using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atv_POO
{
    
    public abstract class Curso
    {
        
        public string Nome {get; set;} = string.Empty; //""
        public int Horas {get; set;}

        public Curso(string NomeConstrutor, int HorasConstrutor)
        {
            Nome = NomeConstrutor;
            Horas = HorasConstrutor;
        }
        
        public abstract double CalcularPreco();

        public virtual void ExibirResumo()
        {
            Console.WriteLine($"Curso: {Nome}");
            Console.WriteLine($"Carga horaria: {Horas}");
            Console.WriteLine($"Preço final: R${CalcularPreco():F2}\n");

        }
        
    }
}