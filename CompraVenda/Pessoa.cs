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
        /// Guardadar o cpf do comprado caso pessoa fisica
        /// </summary>
        public string cpf { get; set; }
        /// <summary>
        /// Guardar o cnpj do comprador caso pessoa seja juridica
        /// </summary>
        public string cnpj { get; set; }
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
            if (tipoComprador == 'F' || tipoComprador == 'f') // verificando se o tipo do comprador é fisica
            {
                // O nome disso é concatenação
                comprador = nome + "\n"; // A variavel comprador vai receber o valor nome + quebra de linha
                comprador += tipoComprador + "\n"; // a variavel comprador vai receber o valor dela mesmo mais o tipoComprador + quebra de linha
                comprador += cpf + "\n"; // a variavel comprador vai receber o valor dela mesma mais o valor do cpf + quebra de linha
                comprador += idade + "\n";// a variavel comprador vai receber o valor dela mesma mais o valor da idade + quebra de linha
            }
            else if(tipoComprador == 'J' || tipoComprador == 'j')  // verificando se o tipo do comprador é juridico
            {
                // O nome disso é concatenação
                comprador = nome + "\n"; // A variavel comprador vai receber o valor nome + quebra de linha
                comprador += tipoComprador + "\n"; // a variavel comprador vai receber o valor dela mesmo mais o tipoComprador + quebra de linha
                comprador += cnpj + "\n"; // a variavel comprador vai receber o valor dela mesma mais o valor do cnpj + quebra de linha
                comprador += idade + "\n";// a variavel comprador vai receber o valor dela mesma mais o valor da idade + quebra de linha
            }

            return comprador; // retorna o comprador
        }

    }
}
