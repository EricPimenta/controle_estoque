public class Produto
{
    {
      public string Nome;
      public double Preco;
      public int Quantidade;
      public Produto (string nome, double preco, int quantidade)
      {
          Nome = nome;
          Preco = preco;
          Quantidade = quantidade;
      }   
    }
    public Produto ()
    {

    }
    public double ValorTotalEmEstoque()
    { 
    return Preco * Quantidade;
    }
         public void AdicionarProduto(int quantidade)
            {
              Quantidade += quantidade;
            }
              public void RemoverProdutos(int quantidade) 
            {
               Quantidade = Quantidade - quantidade;
            }  
               public  overridestringToString()
            {
               return Nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            }            
}    