Estoque estoque = new();

//Atribui valores ao produto01
Produto produto01 = new()
{

    Id = 1,
    Nome = "Mouse G502",
    Marca = "Logitech",
    Preco = 525.99m,
    Quantidade = 10

};

//Atribui valores ao produto02 - teste de tratamentos quantidade negativa e nome não digitado
Produto produto02 = new ()
{

    Id = 2,
    Nome = "",
    Marca = "Samsung",
    Preco = 4489.99m,
    Quantidade = -10

};

//Adiciona os produtos ao estoque
estoque.AdicionarProdutos(produto01);
estoque.AdicionarProdutos(produto02);

//Exibe produtos do estoque
estoque.ExibirProdutos();