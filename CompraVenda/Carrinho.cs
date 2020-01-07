using System;
using System.Collections.Generic;
using System.Text;

namespace CompraVenda
{
    /// <summary>
    /// Classe onde será possivel verificar os produtos que sera comprado e finalizar a comprar
    /// </summary>
    class Carrinho
    {
       
        public Produto Prod { get; set; } // Lista de produto
        public int Quantidade { get; set; } // quantidade que o comprador vai desejar
       
        Program menu = new Program(); // menu do programa

        /// <summary>
        /// 
        /// </summary>
        /// <param name="prod"></param>
        /// <param name="quantDesejada"> Quantidade de um tipo de produto desejada pelo comprador</param>
        public void CarroCompras(Produto prod, int quantDesejada) // mostra os produtos dentro do carrinho
        {
            Prod = prod;
            Quantidade = quantDesejada;
        }
        
        public void FinalizarCompra() // Metodo de finalizar compra, aqui o comprador pode decidir se vai finalizar a compra 
        {
            Console.WriteLine("Deseja finalizar compra? S ou N"); // pergunta se o comprador deseja finalizar a compra 
            char op = char.Parse(Console.ReadLine()); // le uma opcao
            if (op =='s' || op == 'S') // verifica se a opcao é sim
            {
                Prod.quantidadeEstoque -= Quantidade; // atualiza o valor do estoque;
                Console.WriteLine("Estoque Atual: " + Prod.quantidadeEstoque); // mostra o valor do estoque atualizado
            }

        }

        public override string ToString() // metodo que retorna uma string 
        {
            string carro = ""; // variavel carro
            carro = Prod + "\n"; // guarda o valor atual + os dados do produto + quebra de linha
            carro += Quantidade + "\n"; // guarda o valor atual + quantidade + quebra de linha
            return carro ; // retorna o valor da lista  carro
        }


    }
}
