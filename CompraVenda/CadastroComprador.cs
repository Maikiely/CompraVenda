using System;
using System.Collections.Generic;
using System.Text;

namespace CompraVenda
{

    class CadastroComprador
    {
        /// <summary>
        /// Classe de cadastro de comprador
        /// </summary>
        public void CadastrarComprador()
        {
            Pessoa pessoa = new Pessoa(); // Instanciando a classe pessoa
            List<Pessoa> compradores = new List<Pessoa>(); // Criando uma lista de compradores
            ValidarCamposInteiros validacao = new ValidarCamposInteiros();

            int n = 0;
            bool validar = false;

            Console.WriteLine("---------------- Bem vindo ao Cadastro de Comprador ----------------");
            Console.WriteLine("Quantos compradores serão cadastrados?");
            validacao.ValidacaoNumInteiros(ref n, ref validar);

            for (int i = 1; i <= n; i++) // vai cadastrar 2 compradores
            {
                Console.WriteLine("Digite o CPF ou CNPJ: "); // pedindo para digitar o cpf
                pessoa.cpfCnpj = Console.ReadLine(); // lendo o cpf referente da classe pessoa
                if (string.IsNullOrEmpty(pessoa.cpfCnpj))
                {
                    throw new Exception("Não pode haver cpf ou cnpj nulo ou vazio.");
                }

                Console.WriteLine("Digite o Nome: "); // pedindo para informa o nome
                pessoa.nome = Console.ReadLine(); // lendo o nome referente da classe pessoa
                if (string.IsNullOrEmpty(pessoa.nome) || char.IsNumber(pessoa.nome, 0))
                {
                    throw new Exception("O nome do comprador não poder numero ou estar nulo.");
                }

                Console.WriteLine("Digite a idade: "); // pedindo a idade do comprado  
                string idade = Console.ReadLine();
                if (string.IsNullOrEmpty(idade) && !char.IsNumber(idade, 0))
                {
                    throw new Exception("Idade Invalida");
                }
                if (int.TryParse(idade, out int valor)) // le um valor e verifica se é um numero inteiro
                {
                    pessoa.idade = Math.Abs(valor); // atribui para n o valor digitado 
                }

                GetPessoa.Add(pessoa); // Adicionando o comprador na lista
                pessoa = new Pessoa(); // criando um novo comprador

                Console.WriteLine(" ");
            }

            Console.WriteLine(ToString());


            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();

        }

        public override string ToString()
        {
            string resposta= "";
            foreach (var item in GetPessoa) // verificando todos os compradores da lista
            {
                resposta += item.ToString();
            }
            return resposta;

        }

       

        public List<Pessoa> GetPessoa { get; set; } = new List<Pessoa>(); // instancia o metodo getPessoa
    }
}
