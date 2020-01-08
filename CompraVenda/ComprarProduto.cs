using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompraVenda
{
    /// <summary>
    /// Classe de compra, aqui o comprador podera escolher qual o produto quer comprar
    /// e seleciona-los
    /// </summary>
    class ComprarProduto
    {
        /// <summary>
        /// Essa é a clase de compra, nela que é possivel fazer a selição de produtos 
        /// nela é passado um parametro tipo List chamdo estoque que contem todos os dados de todos os produtos
        /// </summary>
        /// <param name="estoque"></param>
        public void Comprar(List<Produto> estoque, List<Pessoa> compradores) // metodo que possui parametro tipo list<Produto> chamado estoque
        {

            Carrinho car = new Carrinho();
            List<Carrinho> ListaCompra = new List<Carrinho>(); // Lista que irá receber o produto e a quantidade do produto
            Pessoa comprador = new Pessoa();

            foreach (var item in estoque) // verificando todos os itens do estoque
            {
                Console.WriteLine(item); // Mostrando todos os itens do estoque
            }

            bool achouComprador = false;

            Console.WriteLine("Digite o seu CNPJ ou CPF");
            comprador.cpfCnpj = Console.ReadLine();
            foreach (var item in compradores)
            {
                if (item.cpfCnpj == comprador.cpfCnpj)
                {
                    comprador = item;
                    achouComprador = true;
                    break;
                }
            }

            if (!achouComprador)
            {
                throw new Exception("Para comprar é necessario cadastro.");
            }

            Console.WriteLine($"Seja bem vindo {comprador.nome}");
            Console.WriteLine($"CNPJ {comprador.cpfCnpj }");
            Console.WriteLine($"Idade {comprador.idade}");
          
            Console.WriteLine("Quantos itens você deseja Comprar"); // Perguntando quatos tipos de itens o comprador deseja comprar
            int quant = 0;
            if (int.TryParse(Console.ReadLine(), out int valor)) // le um valor e verifica se é um numero inteiro
            {
                quant = Math.Abs(valor); // atribui para n o valor digitado 
            }
            for (int i = 1; i <= quant;) // enquanto o contador i for menor que a quantidade de de tipo fornecida
            {
                Console.WriteLine("Qual o produto você deseja comprar?"); // perguntar qual o produto do estoque ele vai querer comprar
                string prod = Console.ReadLine(); // ler o produto         
                if (string.IsNullOrEmpty(prod) || char.IsNumber(prod, 0))
                {
                    throw new Exception("Nome do produto não pode ser numero ou nulo");
                }
   
                // ele pega qualquer produto do estoque e verifica se o nome dele corresponde ao produto digitado
                if (estoque.Any(produto => produto.nome == prod)) // verifica se o aquele produto tem no estoque
                {
                    var produto = estoque.FirstOrDefault(x => x.nome == prod); // ele pega o primeiro valor do estoque que possua o nome iqual ao digitado ou nulo
                    Console.WriteLine("Qual a quantidade desse item você deseja?"); // Pergunta quanto daquele item deseja comprar
                    int quantItem = 0; // lendo a quantidade de item
                    if (int.TryParse(Console.ReadLine(), out valor)) // le um valor e verifica se é um numero inteiro
                    {
                        quantItem = Math.Abs(valor); // atribui para n o valor digitado 
                    }
                    else
                    {
                        throw new Exception("Nao foi possivel converter o seu valor."); // lança uma exção de não possivel converter o valor
                    }
                    if (produto.quantidadeEstoque != 0) // verifica se a quantidade de produto no estoque é diferente de 0
                    {
                        do // para porder fazer as verificações e depois verificar a ondição
                        {
                            if (quantItem <= produto.quantidadeEstoque) // verifica se a quantidade digotada pelo comprador é menor ou igual ao do estoque
                            {
                                car.CarroCompras(produto, quantItem); // Adicionando os itens no carrinho
                                ListaCompra.Add(car); // adicionando os produtos do carrinho na lista
                            }
                            else // se nao
                            {
                                Console.WriteLine("Informe novamente a quantidade:"); // Pede para informar novamente a quantidade novamente
                                quantItem = int.TryParse(Console.ReadLine(), out valor) ? Math.Abs(valor) : throw new Exception("Nao foi possivel converter o seu valor.");
                                
                                if (quantItem <= produto.quantidadeEstoque) // verifica se a quantidade digitada é igual a do estoque 
                                {
                                    car.CarroCompras(produto, quantItem); //Adicionando os itens no carrinho
                                    ListaCompra.Add(car);  // adicionando os produtos do carrinho na lista
                                }
                            }
                            Console.WriteLine(" ");
                        } while (quantItem > produto.quantidadeEstoque); // condiçao de parada, que é quando a quantidade de item é maior do que quantidade no estoque
                        i++; // incrementando o for apenas depois que ele verificar a quantidade       
                    }
                }
                else
                {
                    Console.WriteLine("Esse produto não está no estoque.");// Mostrar essa mensagem quando o produto não tiver no estoque 
                    Console.WriteLine("Você deseja sair ? S ou N");
                    char op = char.Parse(Console.ReadLine());
                    if (op == 's' || op == 'S')
                    {
                        break;
                    }
                }
            }
            Console.Clear();
            foreach (var item in ListaCompra) //pecorrendo a lista
            {
                Console.WriteLine(item); // mostrando os elementos da lista   
            }
            car.FinalizarCompra();

            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
