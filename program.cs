using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Solicitando ao utilizador para colocar as informações dos produtos e os armazenando nas variaveis
            Console.WriteLine("Entre com os dados do produtos:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            //Criação do objeto "P" com todos os parametros
            Produto p = new Produto(nome, preco, quantidade);

            //Inserindo os dados do produto, pegando as respostas das variavéis do objeto criador "p"
            Console.WriteLine("Dados do Produto: " + p);

            //Utilizador precisa informar a quantidade de produtos que vai ser adicionado ao estoque
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            //Inserinbdo os dados do produto e pegando as respostyas que foram armazenadas nasvariaveis da instancia "p"
            Console.WriteLine("Dados do produto atualizados: " + p);

            //Solicitando ao utilizador que insira o número que deverá ser tirado do estoque e colocando o metodo para remover os produtos
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            //Obtendo dados do produtos, obtendo todas as respostas das variaveis da instancia "p"
            Console.WriteLine("Dados do produto atualizados: " + p);
        }
    }
}