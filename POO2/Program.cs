namespace POO_encapsulamento;

class Program
{
    static void Main(string[] args)
    {
        // Encapsulamento

        // ContaBancaria conta = new ContaBancaria();
        // conta.Sacar(200);
        // conta.MostrarSaldo();
        // =---------------
        Cachorro c1 = new Cachorro();
        c1.nome =  "Caramelo";
        c1.idade = 50;
        c1.raca = "Indefinida";
        c1.cor = "Caramelo";
        c1.emitirSom();
        c1.mostrarDados();


        Console.WriteLine("------------------------------------------------");
        

        Gato g1 = new Gato();
        g1.nome = "Feijão";
        g1.idade = 5;
        g1.raca = "Indefinida";
        g1.cor = "Preto";
        g1.emitirSom();
        g1.mostrarDados();

        //Animal a1 = new Animal();
        
        
    }
}
