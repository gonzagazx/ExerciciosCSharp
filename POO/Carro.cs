using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    // classe derivada (subclasse) -> herda informações de veiculo
    public class Carro : Veiculo
    {
        // Atributos da classe
        // public String Marca;
        public String Modelo;
        // public int ano;

        // Métodos (Ações que a classe pode realizar)
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {ano}");
        }
    }
}