namespace Condicionais;

class Program
{
    static void Main(string[] args)
    {
        // int numero = -9;

        // if(numero > 0){
        //     Console.WriteLine("Número positivo");
        // }
        // Console.WriteLine("Numero negativo");


        // Console.WriteLine("Digite um numero: ");
        // int numero = int.Parse(Console.ReadLine());

        // if(numero > 0)
        // {
        //     Console.WriteLine("Positivo");
        // } else if(numero == 0){
        //     Console.WriteLine("O numero é 0");
        // } else{
        //     Console.WriteLine("Negativo");
        // }


        // Console.Write("Digite a sua idade: ");
        // int idade = int.Parse(Console.ReadLine());
        // if(idade < 16 )
        // {
        //     Console.WriteLine("Não pode votar");
        // } else if(idade < 18)
        // {
        //     Console.WriteLine("Voto opcional");
        // } else 
        // {
        //     Console.WriteLine("Voto obrigatorio");
        // }


        // Console.Write("Digite a nota: ");
        // double nota = double.Parse(Console.ReadLine());

        // if (nota >= 7)
        // {
        //     Console.WriteLine("Aprovado!");

        //     if(nota >= 9 )
        //     {
        //         Console.WriteLine("Aprovado e ganhou uma estrela");
        //     }
        // } else if(nota >= 5) {
        //     Console.WriteLine("Recuperação");
        // } else {
        //     Console.WriteLine("Reprovado");
        // }

        // Console.Write("Digite um numero:  ");
        // int N1 = int.Parse(Console.ReadLine());
        // Console.Write("Digite outro numero:  ");
        // int N2 = int.Parse(Console.ReadLine());

        // if(N1 > N2)
        // {
        //     Console.WriteLine("O primeiro numero digitado: " + N1 + "é maior");
        // } else if(N2 > N1){
        //     Console.WriteLine("O segundo numero digitado: "+N2 + "é maior");
        
        // } else 
        // {
        //     Console.WriteLine("Os numeros são iguais");
        // }
    

    // Console.Write("Usuario: ");
    // string usuario = Console.ReadLine();

    
    // Console.Write("Senha: ");
    // string Senha = Console.ReadLine();

    // if (usuario == "admin" && Senha == "1234")
    // {
    //     Console.WriteLine("Acesso permitido");
    // } else {
    //     Console.WriteLine("Acesso negado");
    // }

    // Console.Write("Digite um numero: ");
    // int numero = int.Parse(Console.ReadLine());
    // if ternario
    // string resultado = numero % 2 ==0 ? "Par" : "Impar";

    // Console.WriteLine("Resultado: "+ resultado);
// -/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/
    // if(numero % 2 == 0)
    // {
    //     Console.WriteLine("O numero é par");
    // } else 
    // {
    //     Console.WriteLine("O numero é impar");
    // }

    // int idade = 12;

    // Console.WriteLine( idade >= 18 ? "Maior de idade" : "Menor de idade");





    // Switch case

    // Console.WriteLine("Digite um numero de 1 a 3: ");
    // int opcao = int.Parse(Console.ReadLine());

    // switch (opcao)
    // {
    //     case 1:
    //         Console.WriteLine("Você escolheu a opção 1");
    //             break;
    //     case 2:
    //         Console.WriteLine("Você escolheu a opção 2");
    //             break;
    //     case 3:
    //         Console.WriteLine("Você escolheu a opção 3");
    //             break;
    //     default:
    //         Console.WriteLine("Opção invalida");
    //             break;
    // }

    Console.WriteLine("Digite uma opção: (A, B ou C)");
    string escolha = Console.ReadLine().ToUpper()/*ToUpper transforma o texto em maiuscula*/;

    switch(escolha)
    {
        case "A":
            Console.WriteLine("Você escolheu a opção A");
                break;
        case "B":
            Console.WriteLine("Você escolheu a opção B");
                break;
        case "C":
            Console.WriteLine("Você escolheu a opção C");
                break;
        default:
            Console.WriteLine("Opção invalida");
                break;
    }

    Console.WriteLine("Teste git");
    

    }
}
