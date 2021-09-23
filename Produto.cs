{
    class Produto
    {
        
        //Criando uma variavél do nome do produto privada, no caso poderia ser public também.
        private string _nome;
        
        //Obtendo preco do produto privada, no caso poderia ser public também.
        
        private double _preco;
        
        //Fazendo a quantidade do produto privada, no caso poderia ser public também.
        
        private int _quantidade;

        //Colocando um contrutor sem nada(não possui atributo nenhum)
        public Produto()
        {

        }

        //Criando construtor produto e setando parametros como nome, preco e quantidade
        public Produto  (string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Criando uma variável nome com get
        public string GetNome()
        {
            return _nome;
        }

        //Setando a variavel do nome

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        //Obtendo a variavel de preço com o get

        public double  GetPreco()
        {
            return _preco;
        }

        //Definindo a variavel preço

        public void SetPreco(double preco)
        {
            _preco = preco;
        }

        //Recebendo a variavel quantidade

        public int GetQuantidade()
        {
            return _quantidade;
        }

        //Definindo a variavel quantidade
        public void SetQuantidade(int quantidade)
        {
            _quantidade = quantidade;
        }

        //Criando o método para que o valor total do produto volte em estoque
        public double ValorTotalEmEstoque() 
        { 
            return _preco * _quantidade; 
        }

        //Formando método para adicionar a quantidade indeterminada de produtos na variavel quantidade
        public void AdicionarProduto(int quantidade) 
        { 
            _quantidade += quantidade; 
        }

        //Criando método para tirar a quantidadea de produtos na variavel Quantidade
        public void RemoverProduto(int quantidade) 
        { 
            _quantidade = _quantidade - quantidade; 
        }

        //Retornando os dados das variavéis da classe do produto
        public override string ToString() 
        { 
            return _nome + ", R$ " + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + _quantidade + " unidades, Total: R$ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}