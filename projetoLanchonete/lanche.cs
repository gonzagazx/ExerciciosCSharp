using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoLanchonete
{
    public class Lanche : Produto
    {
        private decimal taxaEmbalagem = 2.00M;
        public Lanche(string nomeProduto, decimal precoBase) : base (nomeProduto, precoBase)
        {

        }

        public override decimal CalcularPrecoFinal() 
        {
            return precoBase + taxaEmbalagem;
        }

        public override void exibirResumoProduto(){
            Console.WriteLine("Tipo: Lanche");
            base.exibirResumoProduto();
            Console.WriteLine();
            
            
        }
    }
}