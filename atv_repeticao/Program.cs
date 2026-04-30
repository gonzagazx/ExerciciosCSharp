namespace atv_repeticao;

class Program
{
    static void Main(string[] args)
    {
//-------------- EX NIVEL FACIL -----------

// EX1

    // for(int i = 1; i <= 10; i++)
    // {
    //     Console.WriteLine(i);
    // }

// EX2
    
    //  for(int i = 10; i >= 1; i--)
    //  {
    //      Console.WriteLine(i);
    //  }

// EX3

    // Console.WriteLine("Informe um numero: ");
    // int numero = int.Parse(Console.ReadLine());

    // for(int i = 1 ; i<=10; i++)
    // {
    //     Console.WriteLine("Tabuada: " + (i * numero));
        
    // }

// EX4

    // int contador = 1;

    // while(contador <= 5)
    // {
    //     Console.WriteLine(contador);
    //     contador++;
    // }

// EX5

    //  for(int i = 1 ; i<=5; i++)
    //  {
    //      Console.WriteLine("Tabuada: " + (i + i));
        
    //  }


//-------------- EX NIVEL MEDIO -----------

// EX1

// int soma = 0;

//     for(int i = 1; i <=5; i++)
//     {
//         Console.WriteLine("informe um numero: "); 
//         int numero = int.Parse(Console.ReadLine());
//         soma = soma + numero;
//         Console.WriteLine("Valor: " + i);   
//     }
//     Console.WriteLine("A soma dos valores: " + soma);
    

// EX2

    // for( int i = 1; i <= 20; i++)
    // {
    //     if(i % 2 == 0)
    //     {
    //         Console.WriteLine("Numeros pares:" + i);
    //     } else
    //     {
    //         Console.WriteLine("____________");
    //     }
    // }

// EX3 

    // int senha = 0;
    // while(senha != 1234){
    //      Console.WriteLine("Informe a sua senha: ");
    //      senha = int.Parse(Console.ReadLine());

    // }

    // Console.WriteLine("Acesso permitido");

// EX4

    // int opcao;
    // do
    //     {
    //         Console.WriteLine("1 - Mostrar mensagem");
    //         Console.WriteLine("2 - Sair");
    //         opcao = int.Parse(Console.ReadLine());

    //     } while (opcao != 2);

    // Console.WriteLine("Programa encerrado");

// EX5

    

    for(int i = 1; i <= 4; i++)
    {
        Console.WriteLine("Informe um numero: ");
        int numero = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Sua Média é: " + numero);

    }
    


    }
}
