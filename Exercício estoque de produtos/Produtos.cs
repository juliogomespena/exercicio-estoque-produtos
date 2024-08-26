using System.Security.Cryptography.X509Certificates;

class Produto
{

    public int Id { get; set; }
    private string nome;
    public string Nome 
    {

        get { return nome; }

        set 
        { 
            
            //se não for preenchido, retorna mensagem de erro
            if(value == null || value == "")
            {

                nome = "NOME NÃO CADASTRADO";
                Erro = true;

            }
            else nome = value;

        }
    
    }
    public string Marca { get; set; }
    public decimal Preco { get; set; }
    private int quantidade;
    public int Quantidade 
    { 
        
        get
        {  return quantidade; }
        
        set
        {
            
            //se for negativo desencadeia mensagem de erro
            if(value < 0)
            {

                Erro = true;

            }
            else quantidade = value;

        }
    
    }
    public bool Erro { get; set; }

}