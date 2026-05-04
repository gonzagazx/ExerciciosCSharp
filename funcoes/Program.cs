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

//     static string verificarSituacao(double nota)
//     {
//         if(nota >= 6)
//         {
//             return "Aprovado";
//         } else
//         {
//             return "Reprovado";
//         }
//     }

//     string[] alunos = new string[3];
//     double[] notas = new double[3];

//     for(int i = 0; i < alunos.Length; i++)
//     {
//         Console.Write("Digite o nome do aluno: ");
//         alunos[i] = Console.ReadLine();

//         Console.WriteLine("Digite a nota do aluno: ");
//         notas[i] = double.Parse(Console.ReadLine());

//     }

//     for(int i = 0; i < alunos.Length; i++)
//     {
//         Console.WriteLine($"Aluno: {alunos[i]} - Nota: {notas[i]} - 
// Situação: {verificarSituacao(notas[i])}}");
//     }
//----------------------------------------------------------------

//Funções matemáticas


//  valor absoluto -> se tiver um valor negativo, transforma em positivo 
// int valor = Math.Abs(-10); //10
// Console.WriteLine(valor);


// Potência
// double potencia = Math.Pow(2,3); // elevado
// Console.WriteLine(potencia);


// raiz quadrada
// double raiz = Math.Sqrt(25);
// Console.WriteLine(raiz);


// Arredondamento
// double numero = Math.Round(3.6);
// Console.WriteLine(numero);


// Random (gerar números aleatórios)
// Random random = new Random(); // cria o gerador de números automáticos
// int numero = random.Next(1, 101); // gera os numeros entre 1 e 100
// int numero = random.Next(101); // gera os numeros começando em 0

// Console.WriteLine(numero);


//Funções para String

//tamanho da String
// String texto ="CSharp";
// int tamanho = texto.Length;

// Console.WriteLine(tamanho);


// string frase = "Olá mundo!";
// frase = frase.Replace("mundo", "C#");

// Console.WriteLine(frase);



//Contains
// string frase = "Estou aprendendo C#";

// if(frase.Contains("C#"))
// {
//     Console.WriteLine("A frase contém 'C#'");
// }

// bool existe = frase.Contains("C#");
// Console.WriteLine(existe);


// int[] numeros = {1, 2, 4, 12, 8};
// // Array.Sort(numeros); //Ordenando valores

// // Console.WriteLine(string.Join(", ", numeros));


// // Inverter valores
// Array.Reverse(numeros);
// Console.WriteLine(string.Join(", ", numeros));




// simular adicionar valores em array
// string[] nomes ={"Ana", "Bruna", "Carlos"};

// string novoNome = "Pedro";

// string[] novoArray = new string [nomes.Length + 1];

// for(int i = 0; i< nomes.Length; i++)
// {
//     novoArray[i] = nomes[i];
// }

// novoArray[novoArray.Length - 1] = novoNome;
// nomes = novoArray;

// foreach(string nome in nomes)
// {
//     Console.WriteLine(nome);
// }



// adicionando elementos com List

// List<string> nomes= new List<string>();

// // adiconando elementos com list
// nomes.Add("Ana");
// nomes.Add("Bruno");
// nomes.Add("Carlos");
// nomes.Add("Pedro");

// //removendo nomes da lista (remove)
// nomes.Remove("Bruno");

// foreach (string nome in nomes)
// {
//     Console.WriteLine(nome);
// }

// // Acessar pela posição(indice)
// Console.WriteLine(nomes[0]); // Ana

// tamanho da lista
// Console.WriteLine(nomes.Count);


// realizando busca dentro da lista
// Console.WriteLine("Digite o nome na busca");
// string nomeDigitado = Console.ReadLine();
// if(nomes.Contains("Ana"))
// {
//     Console.WriteLine("Nome encontrado");
// }

// // Inserindo nome em posição especifica
// nomes.Insert(2, "Paula");


// // Removendo nomes na posição
// nomes.RemoveAt(3);


// // Limpando a lista
// nomes.Clear();


//  foreach (string nome in nomes)
//  {
//     Console.WriteLine(nome);
//  }




//sistema: removendo item digitado
// List<string> produtos = new List<string>();

// produtos.Add("Mouse");
// produtos.Add("Teclado");
// produtos.Add("Monitor");

// Console.Write("Digite o produto para remover: ");
// string remover = Console.ReadLine();

// if(produtos.Contains(remover))
// {
//     // vai remover o produto
//     produtos.Remove(remover);



//     foreach(string produto in produtos)
//     {
//         Console.WriteLine(produto);
//     }
// } else
// {
//     Console.WriteLine("Produto digitado não existe na lista");
// }

// List<string> tarefas = new List<string>();
// int opcao;

// do
// {
//     //Perguntar opções
// Console.WriteLine("Bem vindo(a) ao menu do sistema de tarefas! :) ");
//  Console.WriteLine(" 1 - Adicionar tarefa"); 
//  Console.WriteLine("2 - Listar tarefas");
//  Console.WriteLine("3 - Remover tarefa");
//  Console.WriteLine("0 - sair");

//  opcao = int.Parse(Console.ReadLine());

//  switch(opcao)
//  {
//     case 1:
//         Console.WriteLine("Digite a tarefa: ");
//             tarefas.Add(Console.ReadLine());
//                 break;
//     case 2:
//         foreach(string tarefa in tarefas)
//         {
//             Console.WriteLine("Tarefas:" + tarefa);
//         } break;
//     case 3:
//         Console.WriteLine("Digite a tarefa para remover: ");
//             tarefas.Remove(Console.ReadLine());
//                 break;
//     case 0:
//         Console.WriteLine("saindo...");
//         Console.WriteLine("Sistema encerrando");
//             break;
//     default:
//         Console.WriteLine("Opção inválida!");
//             break;
//  }

 
// }
// while(opcao != 0);

}
}



       