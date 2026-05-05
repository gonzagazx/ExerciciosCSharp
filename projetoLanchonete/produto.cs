using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoLanchonete
{
    public abstract class produto
    {

        // get -> Consegue vizualizar a informação 
        // set -> Consegue modificar a informação 
        public string nome{get; set;}
        public decimal precoBase{get; set;}

        public abstract void calcularPrecoFinal();
        
        public void exibirResumo()
        {
            Console.WriteLine($"Produto: {nome}");
            Console.WriteLine($"Preço Final: ");
            
        }

        
    }
}