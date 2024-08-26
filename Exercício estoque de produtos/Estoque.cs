class Estoque
{

    private List<Produto> Produtos { get; set; } = new();

    public void AdicionarProdutos(Produto produto)
    {

        Produtos.Add(produto);

    }

    public void ExibirProdutos()
    {

        if (Produtos.Count == 0)
        {

            Console.WriteLine("Nenhum item em estoque!");

        }
        else
        {

            foreach (Produto produto in Produtos)
            {

                if (produto.Erro)
                {
                    Console.WriteLine($"ERRO NO ITEM ID: {produto.Id} || NOME: {produto.Nome}");
                }
                else
                {

                    Console.WriteLine($"ID: {produto.Id} || Nome: {produto.Nome} || Marca: {produto.Marca} || Preço: {produto.Preco} || Quantidade: {produto.Quantidade}\n\n");

                }

            }

        }

    }

}