namespace POO;

class Program
{
    static void Main(string[] args)
    {
        // Instanciando o objeto da classe carro
        Carro meuCarro = new Carro();

        // definindo valores para os atributos
        meuCarro.Marca = "Toyota";
        meuCarro.Modelo = "Corolla";
        meuCarro.ano = 2022;

        // chamando método
        meuCarro.ExibirInformacoes();

        // Instanciando o objeto moto
        Moto minhaMoto = new Moto();
        minhaMoto.Marca = "Honda";
        minhaMoto.Ano = 2021;
        minhaMoto.TemPartidaEletrica = true;

        minhaMoto.ExibirdetalhesMoto();
    }
}
