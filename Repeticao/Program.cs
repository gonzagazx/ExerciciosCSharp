namespace Repeticao;

class Program
{
    static void Main(string[] args)
    {
        /*
        for -> usado para quando você sabe quantas vezes vai repetir

        while -> usado para quando você não sabe quantas vezes vai
        repetir e a repetição aconte enquanto uma condição for verdadeira

        do/while -> é parecido com "while", mas a diferença é que mesmo a-
        condição seja falsa, ele executa pelo menos uma vez:
        "Faz primeiro e depois pergunta"

        foreach -> usado para percorrer listas
        */

        // EXEMPLO FOR


        // 1°: int i = 1  -> inicializador, valor inicial
        // 2°: i<= 5      -> condição, se for verdadeiro, continua executando
        // 3°: i++        -> iterador, acrescenta um valor a mais dentro do i 
        //                         (i = i + 1)


        // for(int i = 1; i <=5; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // int soma = 0;

        // for(int i = 1; i <= 10; i++)
        // {
        //     soma = soma + i;
        //     // soma += 1; 
        //           Console.WriteLine("Soma: " + soma);
        // }

        // Console.WriteLine("Soma: " + soma);



        // EXEMPLO WHILE
        // int contador = 1;

        // while(contador <= 5)
        // {
        //     Console.WriteLine(contador);
        //     contador ++;
        // }
        //    Console.WriteLine("contador final: "+ contador);


        int numero = 0;

        while(numero <= 0)
        {
            Console.WriteLine("Digite um numero maior que zero: ");
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Número válido: " + numero);




    // EXERMPLO DO/WHILE

        // int numero = 0;

        // do //faça
        // {
        //     Console.WriteLine("Digite um número maior que zero: ");
        //     numero=int.Parse(Console.ReadLine());
        // }
        // while (numero <= 0 ); //enquanto a condição for verdadeira

        // consolw.WriteLine("Número válido: " + numero);


    //MENU

        // int opcao;

        // do
        // {
        //     Console.WriteLine("1- continuar");
        //     Console.WriteLine("2- sair");
        //     opcao = int.Parse(Console.ReadLine());
        // } while(opcao != 2);

        // Console.WriteLine("Programa encerrado");




    // EXEMPLO FOREACH

        // string[] nomes = new string {"Ana", "Carlos", "Maria"};

        // // para cada   nome na lista  nomes
        // foreach(string nome in nomes)
        // {
        //     // imprima o nome
        //     Console.WriteLine(nome);
        // }

        // int[] numeros = {2, 4, 6, 8};
        // int soma = 0;

        // foreach(int numero in numeros)
        // {
        //     soma += numero;
        // }    // soma = soma + numero
        //     Console.WriteLine(soma);
    }
}
