using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoLanchonete
{
    public class Sobremesa : Produto
    {
        
            public Sobremesa(string nomeProduto, decimal precoBase) : base (nomeProduto, precoBase )
            {
                
            }
        

        public decimal aplicarDesconto()
        {
            return (precoBase * 0.1m);
        }

        public override decimal CalcularPrecoFinal()
        {
            return precoBase - aplicarDesconto();
        }

        public override void exibirResumoProduto()
        {
            Console.WriteLine("Tipo: Sobremesa");
            base.exibirResumoProduto();
            Console.WriteLine($"Desconto: {aplicarDesconto()}");
            Console.WriteLine($"Text");
            
        }

    }
}