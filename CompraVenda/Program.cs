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
                                                          
            int opcao = 0; // fazer a leitura da opção que foi escolhida
            do
            {
                Console.WriteLine("Escolha a opçao que deseja: "); // O sistema pergunta qual a operação sera realizada
                Console.WriteLine("1 - Cadastro de Prouto "); // Mostrar a opçao 1 
                Console.WriteLine("2 - Cadastro de Comprador "); // Mostrar a opcao 2
                Console.WriteLine("3 - Fazer Compras"); // Mostrar a opcao 3
                Console.WriteLine("0 - Sair"); // Mostrar a opcao 0 que a condição de parada do sistema 

                if (int.TryParse(Console.ReadLine(), out int valor)) // le um valor e verifica se é um numero inteiro
                {
                    opcao = Math.Abs(valor); // atribui para n o valor digitado 
                }
                switch (opcao) {
                    case 1:
                        cadProduto.CadastrarProduto(); // quando o metodo é chamado, vai ser possivel cadastrar um produto no estoque
                        break;
                    case 2:
                        cadComprador.CadastrarComprador(); // Chamando esse metodo, será possivel cadastrar um comprador na lista
                        break;
                    case 3:
                        compras.Comprar(cadProduto.GetProduto, cadComprador.GetPessoa);// ele chama o metodo de Comprar da classe ComprarProduto 
                        break;
                    case 0:
                        return;
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (opcao != 0);
   
        }
    }
}
