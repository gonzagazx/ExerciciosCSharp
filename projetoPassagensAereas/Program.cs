namespace projetoPassagensAereas;

class Program
{
    static void Main(string[] args)
    {
        string senha;
        int opcao;

        string[] nomes  = new string[2];
        string[] origens  = new string[2];
        string[] destinos  = new string[2];
        string[] datas  = new string[2];

        int totalPassagens = 0;

        do
        {
            Console.WriteLine("Digite a senha para acessar o sistema");
            senha = Console.ReadLine();

            if (senha != "123456")
            {
                Console.WriteLine("Senha incorreta");
            }
            
        } while( senha != "123456");
        Console.WriteLine($"Acesso liberado");


        do
        {
            Console.WriteLine("======== SISTEMAS DE PASSAGENS AEREAS =========");
            Console.WriteLine("1 - Cadastrar Passagem");
            Console.WriteLine("2 - Listar Passagem");
            Console.WriteLine("3 - sair");
            Console.WriteLine("Escolha uma opção");
            opcao = int.Parse(Console.ReadLine());


            switch(opcao)
            {
                
                case 1:
                if (totalPassagens <= 2)
                {
                Console.WriteLine("====== CADASTO DE PASSAGENS ======");

                Console.WriteLine("Nome do passageiro");
                nomes[totalPassagens] = Console.ReadLine();

                Console.WriteLine("Origem: ");
                origens[totalPassagens] = Console.ReadLine();

                Console.WriteLine("Destino: ");
                destinos[totalPassagens] = Console.ReadLine();

                Console.WriteLine("Data da viagem: ");
                datas[totalPassagens] = Console.ReadLine();

                totalPassagens++;
                
                Console.WriteLine($"Passagem cadastrada com sucesso");
                } else
                {
                    Console.WriteLine("Limite maximo de 2 passageiros"); 
                }
                break;

                case 2:
                Console.WriteLine($"====== LISTAGEM DE PASSAGENS ======");
                if ( totalPassagens == 0)
                {
                    Console.WriteLine($"Nenhuma passagem cadastrada");
                } else
                {
                    for (int i = 0; i < totalPassagens; i++)
                    {
                        Console.WriteLine($"Passageiro {i+ 1}");
                        Console.WriteLine($"Nome: {nomes [i]}");
                        Console.WriteLine($"Origem {origens [i]}");
                        Console.WriteLine($"Destino {destinos [i]}");
                        Console.WriteLine($"Data da viagem {datas[i]}");
                        
                    }
                }
                break;

                case 3:

                Console.WriteLine("Saindo do sistema");
                break;

                default:
                Console.WriteLine($"Opção invalida!");
                break;
                
            }
            
            
        } while (opcao != 3);
        
        
    }
}
