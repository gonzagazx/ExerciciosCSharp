using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_encapsulamento
{
    public abstract class Animal
    {
        public string nome;
        public int idade;
        public string raca;
        public string cor;

    // virtual = O método será sobrescrito 
        public virtual void emitirSom()
        {
            Console.WriteLine("O animal faz um som");
        }

        public void mostrarDados()
        {
            Console.WriteLine($"O animal de nome: {nome} tem {idade} anos");
        }

        public abstract void comer();

    }
}