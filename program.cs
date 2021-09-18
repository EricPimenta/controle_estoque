public class Produto
{
    publicstringNome;
     publicdoublePreco;
      publicintQuantidade;
      publicProduto (stringnome, doublepreco, intquantidade)
      {
          Nome = nome;Preco= preco;Quantidade = quantidade;
          }
          publicProduto ()
          {
              public doubleValorTotalEmEstoque() {returnPreco* Quantidade;}publicvoidAdicionarProduto(intquantidade) {Quantidade += quantidade;}publicvoidRemoverProdutos(intquantidade) {Quantidade = Quantidade -quantidade;}publicoverridestringToString() {returnNome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);}}
          }