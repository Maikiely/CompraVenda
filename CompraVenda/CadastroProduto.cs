using System;
using System.Collections.Generic;
using System.Text;

namespace CompraVenda
{
    class CadastroProduto
    {
        public void CadastrarProduto()
        {
            Produto produto = new Produto(); // Instanciando a classe pessoa
            ValidarCamposInteiros validacao = new ValidarCamposInteiros(); // Instanciando a classe de validaçao de numeros inteiros

            Console.WriteLine("---------------- Bem vindo ao Cadastro de Produto ----------------"); // mensagem de bem vindo ao cadastro de produto        
            Console.WriteLine("Quantos produtos serão cadastrados?"); // Pergunta a quantidade de produtos que será cadastrado
            int n = 0; // inicializa um valor inteiro
            bool validar = false; // inicia um valor do tipo booleano igual a false

            validacao.ValidacaoNumInteiros(ref n, ref validar); // valida se o numero é inteiro 

            for (int i = 1; i <= n; i++)  // faz o loop que só para depois que todos os produtos sejam cadastrados
            {
                Console.WriteLine("Digite o nome do produto: "); // pede o nome do produto
                produto.nome = Console.ReadLine(); // le o nome 
               
                if (string.IsNullOrEmpty(produto.nome) || char.IsNumber(produto.nome, 0))
                {
                    throw new Exception("O nome do produto esta nulo ou é numerico");
                }
               
                Console.WriteLine("Digite a quantidade do produto em estoque: "); // pede a quantidade de produtos do estoque
                produto.quantidadeEstoque = int.TryParse(Console.ReadLine(), out int valor) ? Math.Abs(valor) : throw new Exception("Nao foi possivel converter o seu valor.");
         
                Console.WriteLine("Digite o valor do produto: "); // pede o valor do produto
                produto.valor = float.TryParse(Console.ReadLine(), out float valor2) ? Math.Abs(valor2) : throw new Exception("Tente outra vez");

              
                GetProduto.Add(produto); // adiciona o protudo na lista

                produto = new Produto(); // cria um novo produto para ser adicionado na lista

                Console.WriteLine(" "); // pula uma linha
            }

            foreach (var item in GetProduto) // verifica se o item esta na lista
            {
                Console.WriteLine(item); // mostra o item 
                
            }
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();

        }

        public List<Produto> GetProduto { get; set; } = new List<Produto>(); // instancia o metodo getProduto

    }

}
