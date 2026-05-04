using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Moto : Veiculo
    {
        public bool TemPartidaEletrica;
        public void ExibirdetalhesMoto()
        {
            ExibirDetalhes(); // Método herdado de veiculo
            Console.WriteLine($"Partida elétrica: {TemPartidaEletrica}");
        }
    }
}