using System;
using System.Collections.Generic;
using System.Text;

namespace CompraVenda
{

    /// <summary>
    /// Esta classe é a onde contém os dados que serao necessario guardar do comprador.
    /// </summary>
    class Pessoa
    {
        /// <summary>
        /// tipoComprador é para identificar se é pessoa juridica ou fisica
        /// </summary>
        public char tipoComprador { get; set; }
        /// <summary>
        /// Guardar o nome do comprador
        /// </summary>
        public string nome { get; set; }
        /// <summary>
        /// Guardadar o cpf ou cnpj do comprado caso pessoa fisica
        /// </summary>
        public string cpfCnpj { get; set; }
       
        /// <summary>
        /// Guardar a idade da pessoa
        /// </summary>
        public int idade { get; set; }
    
        /// <summary>
        /// /Este metodo vai retorna uma string com todos os dados de um comprador
        /// </summary>
       
        public override string ToString()
        {

            string comprador = ""; // criando uma variavel do tipo string global 
            comprador = "Nome: " + nome + "\n"; // A variavel comprador vai receber o valor nome + quebra de linha
            comprador += "Idade: " + idade + "\n";// a variavel comprador vai receber o valor dela mesma mais o valor da idade + quebra de linha
            comprador += "CPF / CNPJ: " + cpfCnpj + "\n"; // a variavel comprador vai receber o valor dela mesma mais o valor do cpf + quebra de linha

            return comprador; // retorna o comprador
        }

    }
}
