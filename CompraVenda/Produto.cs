using System;
using System.Collections.Generic;
using System.Text;

namespace CompraVenda
{
    /// <summary>
    /// Classe que pega a classe que pega os dados do produto para cadastra-lo
    /// </summary>
    class Produto
    {
        /// <summary>
        /// Nome do produto
        /// </summary>
        public string nome { get; set; }
        /// <summary>
        /// Quantidade do produto em estoque
        /// </summary>
        public int quantidadeEstoque { get; set; }
        /// <summary>
        /// valor do produto
        /// </summary>
        public float valor { get; set; }

        /// <summary>
        /// Este metodo vai retorna uma string com todos os dados do produto
        /// </summary>
       
        public override string ToString()
        {

            string produto = "Nome: " + nome + "\n"; // A variavel produto vai receber o valor nome + quebra de linha
            produto += "Quantidade: " + quantidadeEstoque + "\n"; // A variavel produto vai receber o valor dela mesma mais a quantidade em estoque + quebra de linha 
            produto += "Valor: " + valor + "\n";// A variavel produto vai receber o valor dela mesma mais o valor do produto + quebra de linha 

            return produto; // retorna o produto
        }

    }
}
