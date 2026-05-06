using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoLanchonete
{
    public abstract class Produto
    {

        // get -> Consegue vizualizar a informação 
        // set -> Consegue modificar a informação 
        private decimal precoBaseProduto;
        public string nomeProduto{get; set;}
        public decimal precoBase
        {
            get { return precoBaseProduto; }
            
             set
             {
                if (value >= 0)
                    precoBaseProduto = value;
                else 
                    precoBaseProduto = 0;
             }}

        //construtor
        public  Produto(string nome, decimal precoBase)
        {
            nomeProduto = nome;
            precoBaseProduto = precoBase;
        }
        
  
        
// metodo abstrato
        public abstract decimal CalcularPrecoFinal();

// metodo  para 
        public virtual  void exibirResumoProduto() {
            Console.WriteLine($"Produto: {nomeProduto}");
            Console.WriteLine($"Preço Final: R${CalcularPrecoFinal()}");
            
        }        
    }
}