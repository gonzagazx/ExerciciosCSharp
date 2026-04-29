namespace atv_condicionais;

class Program
{
    
    static void Main(string[] args)
    {

        // -----------------EX NIVEL FACIL-------------

//EX1

    //  Console.WriteLine("Informe a temperatura em Graus Celsius: ");
    //  double temp = double.Parse(Console.ReadLine());

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
//     case 7:
//         Console.WriteLine("Fim de semana");
//             break;
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//     case 6:
//         Console.WriteLine("Dia útil");
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

    // -----------------EX NIVEL DIFICIL-------------

// EX1

    // Console.Write("Informe a sua nota: ");
    // int n1 = int.Parse(Console.ReadLine());

    // if (n1 >= 7)
    // {
    //     Console.WriteLine("Aprovado");
    // } else if ( n1 == 5 || n1 < 7)
    // {
    //     Console.WriteLine("Recuperação");
    // } else
    // {
    //     Console.WriteLine("Reprovado");
    // }

// EX2

    // Console.Write("Informe o lado do triângulo: ");
    // int n1 = int.Parse(Console.ReadLine());
    // Console.Write("Informe o lado do triângulo: ");
    // int n2 = int.Parse(Console.ReadLine());
    // Console.Write("Informe o lado do triângulo: ");
    // int n3 = int.Parse(Console.ReadLine());


    

    // if (n1 > 0 && n2 > 0 && n3 > 0)
    // {
    //     Console.WriteLine("pode formar um triângulo");
    // } else
    // {
    //     Console.WriteLine("Invalido");
    // }

// EX3

    // Console.Write("Informe um numero: ");
    // int n1 = int.Parse(Console.ReadLine());
    // Console.Write("Informe um numero: ");
    // int n2 = int.Parse(Console.ReadLine());
    // Console.Write("Informe o operador (+, -, *, /): ");
    // string operador =Console.ReadLine();

    // double soma = n1 + n2;
    // double subtracao = n1 - n2;
    // double multi = n1 * n2;
    // double div = n1 / n2;
    // if (operador == "+")
    // {
    //     Console.WriteLine(soma);
    // } else if ( operador == "-")
    // {
    //     Console.WriteLine(subtracao);
    // } else if ( operador == "*")
    // {
    //     Console.WriteLine(multi);
    // } else if (operador == "/")
    // {
    //     Console.WriteLine(div);
    // } else
    // {
    //     Console.WriteLine("Operador invalido");
    // }

// EX4

    // string adm = "admin";
    // string senhaAdm = "1234" ;

    // Console.Write("Informe o seu usuario: ");
    // string usuario = Console.ReadLine();
    // Console.Write("Informe a sua senha: ");
    // string senha = Console.ReadLine();


    // if (usuario == adm && senha == senhaAdm)
    // {
    //      Console.WriteLine("Acesso liberado");
    // } else
    // {
    //     Console.WriteLine("Acesso negado");
    // }
    
// EX5

    // Console.WriteLine("digite um numero");
    // int numero = int.Parse(Console.ReadLine());
    // string resultado = numero == 0 ? "zero"
    // : (numero > 0 ? "Positivo" : "Negativo");

    // Console.WriteLine("Seu numero é: " + resultado);

// EX6

    // Console.WriteLine("Digite um numero:");
    // int N1 = int.Parse(Console.ReadLine());
    // Console.WriteLine("Digite outro numero:");
    // int N2 = int.Parse(Console.ReadLine());
    // Console.WriteLine("Qual operação você deseja fazer: (1- Somar, 2- Subtrair, 3- Multiplicar, 4- Dividir)");
    // int opcao = int.Parse(Console.ReadLine());

    // switch(opcao)
    // {
    //     case 1:
    //         Console.WriteLine(N1 + N2);
    //             break;
    //     case 2:
    //         Console.WriteLine(N1-N2);
    //             break;
    //     case 3:
    //         Console.WriteLine(N1 * N2);
    //             break;
    //     case 4:
    //     if( N2 == 0 )
    //     {
    //         Console.WriteLine("indefinido");
    //     } else
    //     {
    //         Console.WriteLine(N1 / N2);
    //     }
    //             break;
    //     default:
    //         Console.WriteLine("Operador invalido");
    //             break;
    // }

//  EX7
    Console.WriteLine("Água = 5 Reais / Refrigerante = 7 reais / Suco = 6 reais");
    Console.WriteLine("Escolha a bebida: 1 - Água, 2 - Refrigerante, 3- Suco");
    int escolha = int.Parse(Console.ReadLine());



    switch(escolha)
    {
        case 1:
            Console.WriteLine("Água");
                break;
        case 2:
            Console.WriteLine("Refrigerante");
                break;
        case 3:
            Console.WriteLine("Suco");
                break;
        default:
            Console.WriteLine("Invalido");
                break;
    }

    }
}
