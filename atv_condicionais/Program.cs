namespace atv_condicionais;

class Program
{
    
    static void Main(string[] args)
    {

        // -----------------EX NIVEL FACIL-------------

//EX1

    //  Console.WriteLine("Informe a temperatura em Graus Celsius: ");
    //  int temp = int.Parse(Console.ReadLine());

    //  if ( temp < 15)
    //  {
    //     Console.WriteLine("Está frio");
    //  } else 
    //  {
    //     Console.WriteLine("Está agradavel/quente");
    //  }

// EX2

    // Console.WriteLine("Informe um numero: ");
    // int numero = int.Parse(Console.ReadLine());

    // if(numero > 100) 
    // {
    //     Console.WriteLine("Numero maior que 100");
    // } else if (numero == 100)
    // {
    //     Console.WriteLine("Numero igual a 100");
    // } else
    // {
    //     Console.WriteLine("Numero menor que 100");
    // }

// EX3

    // Console.WriteLine("Informe a sua senha: ");
    // String senha = Console.ReadLine();

    // if(senha == "123") {
    //     Console.WriteLine("Acesso permitido");
    // } else{
    //     Console.WriteLine("Acesso negado");
    // }

// EX4

    // Console.WriteLine("Informe um numero: ");
    // int numero = int.Parse(Console.ReadLine());

    // if (numero >= 0 ) 
    // {
    //     Console.WriteLine("Numero valido");
    // } else {
    //     Console.WriteLine("Numero invalido");
    // }

// EX5

    // Console.WriteLine("Informe a sua idade: ");
    // int idade = int.Parse(Console.ReadLine());

    // if(idade >= 16) {
    //     Console.WriteLine("Cadastro permitido");
    // } else{
    //     Console.WriteLine("Cadastro não permitido");
    // }

// EX6

    // Console.WriteLine("Escolha uma opção: (1 - Manhã, 2 - Tarde e 3 - Noite)");
    // int opcao = int.Parse(Console.ReadLine());

    // switch (opcao) 
    // {
    //     case 1:
    //         Console.WriteLine("Manhã");
    //             break;
    //     case 2:
    //         Console.WriteLine("Tarde");
    //             break;
    //     case 3:
    //         Console.WriteLine("Noite");
    //             break;
    //     default:
    //         Console.WriteLine("inválido");
    //             break;

    // }

// EX7

    // Console.WriteLine("Escolha uma opção: (1 - Novo jogo, 2 - Carregar jogo e 3 - Sair)");
    // int opcao = int.Parse(Console.ReadLine());

    // switch(opcao)
    // {
    //     case 1:
    //         Console.WriteLine("Novo jogo");
    //             break;
    //     case 2:
    //         Console.WriteLine("Carregar jogo");
    //             break;
    //     case 3:
    //         Console.WriteLine("Sair");
    //             break;
    //     default:
    //         Console.WriteLine("Opção invalida");
    //             break;

    // }

// -----------------EX NIVEL MEDIO-------------

// EX1

    // Console.WriteLine("Digite a idade:");
    // int idade = int.Parse(Console.ReadLine());

    // if(idade <=12 )
    // {
    //     Console.WriteLine("Criança");
    // } else if(idade  <= 17 && idade >= 13  ) {
    //     Console.WriteLine("Adolecente");
    // } else {
    //     Console.WriteLine("Adulto");
    // }

// EX2

    // Console.WriteLine("Digite um numero:");
    // int N1 = int.Parse(Console.ReadLine());
    // Console.WriteLine("Digite outro numero:");
    // int N2 = int.Parse(Console.ReadLine());

    // int maior = N1 > N2 ? N1 : N2;

    // Console.WriteLine("O maior numero digitado: " + maior);

// EX3
    
    // Console.WriteLine("Informe a sua idade: ");
    // int idade = int.Parse(Console.ReadLine());
    // Console.WriteLine("Possui ingresso? (true/false)");
    // bool ingresso = bool.Parse(Console.ReadLine());

    // if(idade >= 18 || ingresso == true)
    // {
    //     Console.WriteLine("Pode entrar");
    // } else 
    // {
    //     Console.WriteLine("Não pode entrar");
    // }

// EX4

    // Console.WriteLine("Informe um numero: ");
    // int numero = int.Parse(Console.ReadLine());
    
    // if (numero >= 0 && numero <= 10 )
    // {
    //     Console.WriteLine("Numero valido");
    // } else
    // {
    //     Console.WriteLine("Numero invalido");
    // }

// EX5

    // Console.WriteLine("Informe a sua idade: ");
    // int idade = int.Parse(Console.ReadLine());    

    // if(idade < 18)
    // {
    //     Console.WriteLine("Sem desconto");
    // } else if(idade >= 18 && idade <= 19)
    // {
    //     Console.WriteLine("Desconto de 10%");
    // } else
    // {
    //     Console.WriteLine("Desconto de 20%");
    // }

// EX6

    // Console.WriteLine("Informe o valor da compra: ");
    // double compra = double.Parse(Console.ReadLine());

    // String desconto = compra < 200 ? "5% de desconto" : "15% de desconto";

    // Console.WriteLine("Seu desconto: "+ desconto);

// EX7

//     Console.WriteLine("Qual operação você deseja fazer: (1- Somar, 2- Subtrair, 3- Multiplicar, 4- Dividir)");
//     int opcao = int.Parse(Console.ReadLine());
//     Console.WriteLine("Digite um numero:");
//     int N1 = int.Parse(Console.ReadLine());
//     Console.WriteLine("Digite outro numero:");
//     int N2 = int.Parse(Console.ReadLine());

//     switch(opcao)
//     {
//         case 1:
//             Console.WriteLine(N1 + N2);
//                 break;
//         case 2:
//             Console.WriteLine(N1 - N2);
//                 break;
//         case 3:
//             Console.WriteLine(N1 * N2);
//                 break;
//         case 4:
//             Console.WriteLine(N1 / N2);
//                 break;
//         default:
//             Console.WriteLine("Opção invalida");
//                 break;
//     }

// EX8

//  Console.WriteLine("Informe o numero correspondente ao dia da semana (1 a 7)");
//  int numero = int.Parse(Console.ReadLine());

//  switch (numero)
//  {
//     case 1:
//         Console.WriteLine("Fim de semana");
//             break;
//     case 2:
//         Console.WriteLine("Dia útil");
//             break;
//     case 3:
//         Console.WriteLine("Dia útil");
//             break;
//     case 4:
//         Console.WriteLine("Dia útil");
//             break;
//     case 5:
//        Console.WriteLine("Dia útil");
//             break;
//     case 6:
//         Console.WriteLine("Dia útil");
//             break;
//     case 7:
//         Console.WriteLine("Fim de semana");
//             break;
//     default:
//         Console.WriteLine("Opção invalida");
//             break;
    
            
//  }

// EX 9

    // Console.WriteLine("Informe o seu plano de 1 a 3");
    // int opcao = int.Parse(Console.ReadLine());

    // switch(opcao)
    // {
    //     case 1:
    //         Console.WriteLine("Plano Básico");
    //         Console.WriteLine("10MB");
    //             break;
    //     case 2:
    //         Console.WriteLine("Plano Intermediário");
    //         Console.WriteLine("50MB");
    //             break;
    //     case 3:
    //         Console.WriteLine("Plano Premium");
    //         Console.WriteLine("100MB");
    //             break;
    //     default:
    //         Console.WriteLine("Opção invalida");
    //              break;
    // }
    }
}
