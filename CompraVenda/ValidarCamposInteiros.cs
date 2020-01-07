using System;
using System.Collections.Generic;
using System.Text;

namespace CompraVenda
{
    /// <summary>
    /// Validação de numeros inteiros 
    /// </summary>
    class ValidarCamposInteiros
    {
        public void ValidacaoNumInteiros(ref int n, ref bool validar) // metodo para verificar se o numero digitado é um valor inteiro
        {
            do // loop que executa e depois verifica a condição
            {
                if (int.TryParse(Console.ReadLine(), out int valor)) // ele tenta passar o valor para inteiro
                {
                    n = Math.Abs(valor); // se for atribue o valor de valor para n
                    validar = true; // seta validar como true para sair do loop
                }
                else // se não conseguir
                {
                    Console.WriteLine("Digite um numero inteiro retardado"); // pede para ser digitado de novo 
                    if (int.TryParse(Console.ReadLine(), out valor)) // le um valor e verifica se é um numero inteiro
                    {
                        n = Math.Abs(valor); // atribui para n o valor digitado 
                        validar = true; // seta validar como true
                    }
                    else // caso ele não digite um valor inteiro
                    {
                        validar = false; // validar continua como false
                    }
                }
            } while (validar == false); // verifica quando validar vai ser igual a true
        }
    }
}
