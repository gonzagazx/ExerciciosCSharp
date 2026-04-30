namespace funcoes;

class Program
{
    static void Main(string[] args)
    {
        /*
            tipoDeRetorno NomeDaFuncao(parametro)
            {
                comandos da função
            }
        
        */


        // Sem parametros e sem retorno
        // static void MostrarMensagem()
        // {
        //     Console.WriteLine("Olá! Boa noite!");
        // }

        // Chamando a função

        // MostrarMensagem();



        // função com parametro
        // Parametro é string nome
        // static void Saudacao(string nome)
        // {
        //     Console.WriteLine($"Olá, {nome}!");
        // }

        // Saudacao("Matheus");


        //! função com retorno
        // Parametros a,b
        // static int Somar(int a, int b)
        // {
        //     //int soma = a + b;
        //     return a + b;
        // }
        // int resultado = Somar(10,2);
        // Console.WriteLine(resultado);


        // static void ExibirDobro(int num);
        // {
        //     Console.WriteLine(num * 2);
        // }

        // ExibirDobro(10);




        // Arrays -> Armazena varios valores do mesmo tipo em uma única variavel
        // int[] numeros = new int [5];


        // Console.WriteLine(numeros);

        // numeros[0] = 2;
        // numeros[1] = 3;
        // numeros[2] = 5;
        // numeros[3] = 8;
        // numeros[4] = 0;

        // Console.WriteLine(numeros);


        // // soluçã alternativa para mostrar o array (impresso em string)
        // Console.WriteLine(string.Join(",", numeros));



        // string[] nomes = {"Matheus", "Mota", "Gonzaga" };

        // // percorrendo com fir
        // for(int i = 0; i< nomes.Length; i++)
        // {
        //     Console.WriteLine(nomes[i]);
        // }

        // // percorrendo com foreach
        // foreach(string nome in nomes)
        // {
        //     Console.WriteLine(nome);
        // }



        // função + array

        // static double calcularMedia(double[] notas)
        // {
        //     double soma = 0;

        //     for(int i = 0; i < notas.Length; i++)
        //     {
        //         soma += notas[i];
        //         //soma = soma + nota[posição]
        //     }

        //     return soma / notas.Length;
        // }

        // double[] notasAluno = {8.0, 7.5, 9.0, 6.5};

        // double media = calcularMedia(notasAluno);

        // Console.WriteLine($"Média final: {media}");


        // outro exemplo
        // int[] numeros = new int[5];
        // int soma = 0;

        // for(int i= 0; i < numeros.Length; i++)
        // {
        //     Console.WriteLine($"Digite o {i + 1}º numero");
        //     numeros[i] = int.Parse(Console.ReadLine());

        //     soma += numeros[i];

        // }

        // Console.WriteLine(string.Join(",", numeros));
        // Console.WriteLine($"A soma dos números é: {soma}");

// -----------------DESAFIO------------------

    static string verificarSituacao(double nota)
    {
        if(nota >= 6)
        {
            return "Aprovado";
        } else
        {
            return "Reprovado";
        }
    }

    string[] alunos = new string[3];
    double[] notas = new double[3];

    for(int i = 0; i < alunos.Length; i++)
    {
        Console.Write("Digite o nome do aluno: ");
        alunos[i] = Console.ReadLine();

        Console.WriteLine("Digite a nota do aluno: ");
        notas[i] = double.Parse(Console.ReadLine());

    }

    for(int i = 0; i < alunos.Length; i++)
    {
        Console.WriteLine($"Aluno: {alunos[i]} - Nota: {notas[i]} - 
Situação: {verificarSituacao(notas[i])}}");
    }
}


       