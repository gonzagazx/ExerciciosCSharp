namespace projetoLanchonete;

class Program
{
    static void Main(string[] args)
    {
        List<Produto> pedido = new List<Produto>();

        pedido.Add(new Lanche("X-Salada", 26.00M));
        pedido.Add(new Bebida("Coca-Cola", 6.00M));
        pedido.Add(new Sobremesa("Açai", 12.00M));

        Console.WriteLine($"===== Resumo Pedido =====");

        decimal total = 0;


        foreach (Produto produto in pedido)
        {
            produto.exibirResumoProduto();
            total += produto.CalcularPrecoFinal();

        }

        Console.WriteLine($"Total do pedido: R$ {total}");
        
        

    }
}
