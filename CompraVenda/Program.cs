using System;
using System.Collections.Generic;

namespace CompraVenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();   // Instanciando a classe Pessoa para poder utilizar suas informações
            CadastroProduto cadProduto = new CadastroProduto();// Instanciando a classe CadastroProduto chamar o metodo
            CadastroComprador cadComprador = new CadastroComprador(); // Instanciando a classe CadastroComprador para poder chamar o metodo de cadastrar
            ComprarProduto compras = new ComprarProduto(); // Instanciando a classe comprarProduto para poder chamar o metodo de comprar
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Escolha a opçao que deseja: "); // O sistema pergunta qual a operação sera realizada
            Console.WriteLine("1 - Cadastro de Prouto "); // Mostrar a opçao 1 
            Console.WriteLine("2 - Cadastro de Comprador "); // Mostrar a opcao 2
            Console.WriteLine("3 - Fazer Compras"); // Mostrar a opcao 3
            Console.WriteLine("0 - Sair"); // Mostrar a opcao 0 que a condição de parada do sistema 
            int opcao = 0; // fazer a leitura da opção que foi escolhida
            if (int.TryParse(Console.ReadLine(), out int valor)) // le um valor e verifica se é um numero inteiro
            {
                opcao = Math.Abs(valor); // atribui para n o valor digitado 
            }
            Console.Clear();
            while (opcao != 0) // verifica se a opcao digitada é diferente de 0, e enquanto for, sera realizado as funções dentro do bloco
            {              
                if (opcao == 1) // verifica se a opcao digitada foi a 1, caso sim, ele chama o  metodo CadastrarProduto da clase de cadastrar Produto 
                {        
                    cadProduto.CadastrarProduto(); // quando o metodo é chamado, vai ser possivel cadastrar um produto no estoque
                }else if (opcao == 2) // caso não foi a opçao 1 a escolhida, verifica se foi a 2, e sera chamado o metodo de Cadastrar um comprador
                {
                    cadComprador.CadastrarComprador(); // Chamando esse metodo, será possivel cadastrar um comprador na lista
                }else if (opcao == 3)// caso a opcao escolhida não tenha sido nem a 2 e nem a 1, ele verifica se a opcao é a 3
                { 
                    compras.Comprar(cadProduto.GetProduto, cadComprador.GetPessoa);// ele chama o metodo de Comprar da classe ComprarProduto 
                }

                // Finalizado as tarefas das opções escolhida, será perguntado e mostrado novamente as opçoes
                // Caso o usuario não digite nenhuma opcao valida, sera perguntado novamente
                Console.WriteLine("Escolha a opçao que deseja: ");  
                Console.WriteLine("1 - Cadastro de Prouto ");
                Console.WriteLine("2 - Cadastro de Comprador ");
                Console.WriteLine("3 - Fazer Compras");
                Console.WriteLine("0 - Sair");
                
                opcao = 0; // fazer a leitura da opção que foi escolhida
                if (int.TryParse(Console.ReadLine(), out valor)) // le um valor e verifica se é um numero inteiro
                {
                    opcao = Math.Abs(valor); // atribui para n o valor digitado 
                }

                Console.Clear();
            } 

        }
    }
}
