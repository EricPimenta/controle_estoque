class Produto
    {
        //Criando variaveis de preco, nome e quantidade (Poderia ser public também)
       
        private string _nome;
        private double _preco;
        private int _quantidade;

        //Criando um construtor sem atributo algum
        public Produto()
        {

        }

        //Criando construtor Produto e passando como parametro variaveis nome, preco e quantidade
        
        public Produto  (string nome, double preco, int quantidade)
        {
            //Juntando as variaveis da classe do produto com as do método do produto
           
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Declarando a propriedade de get (pegar) and set (setar=escolher) da variavel nome
        
        public string Nome{
            get {return _nome; }
            set{
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //Setando a propriedade get (pegar) da variavel preco
       
       
        public double Preco
        {
            get { return _preco;  }
        }

        //Declarando a propriedade get (pegar) da variavel preco 
        
        public int Quantidade
        {
            get { return _quantidade; }
        } 

        //Criando o método que irá dar o valor total do produto em estoque
        
        public double ValorTotalEmEstoque() 
        { 
            return _preco * _quantidade; 
        }

        //Criando método para adicionar a quantidade quanto o usuario desejar de produtos na variavel Quantidade
        
        public void AdicionarProduto(int quantidade) 
        { 
            _quantidade += quantidade; 
        }

        //Criando método para tirar a quantidade quanto o usuario desejar de produtos na variavel Quantidade
        
        public void RemoverProduto(int quantidade) 
        { 
            _quantidade = _quantidade - quantidade; 
        }

        //Trazendo de volta os dados das variaveis da classe do produto
        
        public override string ToString() 
        { 
            return _nome + ", R$ " + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + _quantidade + " unidades, Total: R$ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}