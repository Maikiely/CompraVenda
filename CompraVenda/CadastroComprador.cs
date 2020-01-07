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
                Console.WriteLine("Por favor identifique o tipo de usuario: F - Física ou J - Jurídica "); // pedindo para identificar o tipo de usuario
                pessoa.tipoComprador = char.Parse(Console.ReadLine()); // lendo o tipo de usuario da classe pessoa
                CadastroPessoaFisicaJuridica(pessoa);

                GetPessoa.Add(pessoa); // Adicionando o comprador na lista
                pessoa = new Pessoa(); // criando um novo comprador

                Console.WriteLine(" ");
            }

            foreach (var item in GetPessoa) // verificando todos os compradores da lista
            {
                Console.WriteLine(item); //Exibindo todos os compradores da lista
            }


        }



        private static void CadastroPessoaFisicaJuridica(Pessoa pessoa)
        {
            if (pessoa.tipoComprador == 'F' || pessoa.tipoComprador == 'f') // verificando se o tipo de usuario é fisico
            {
                Console.WriteLine("Digite o CPF: "); // pedindo para digitar o cpf
                pessoa.cpf = Console.ReadLine(); // lendo o cpf referente da classe pessoa
                if (string.IsNullOrEmpty(pessoa.cpf))
                {
                    throw new Exception("Não pode haver cpf nulo ou vazio.");
                }
                Console.WriteLine("Digite o Nome: "); // pedindo para informa o nome
                pessoa.nome = Console.ReadLine(); // lendo o nome referente da classe pessoa
                if (string.IsNullOrEmpty(pessoa.nome))
                {
                    throw new Exception("Não pode haver nome nulo ou vazio.");
                }
                if (char.IsNumber(pessoa.nome, 0))
                {
                    throw new Exception("Nome do produto não pode ser numero");
                }
                Console.WriteLine("Digite a idade: "); // pedindo a idade do comprado  
                string idade = Console.ReadLine();
                if (!char.IsNumber(idade, 0))
                {
                    throw new Exception("Idade Invalida");
                }
                if (int.TryParse(idade, out int valor)) // le um valor e verifica se é um numero inteiro
                {
                    pessoa.idade = Math.Abs(valor); // atribui para n o valor digitado 
                }

            }
            else if (pessoa.tipoComprador == 'J' || pessoa.tipoComprador == 'j') // Verificando se a pessoa é do tipo juridica
            {
                Console.WriteLine("Digite o CNPJ: "); // pedindo para digitar o cnpj
                pessoa.cnpj = Console.ReadLine(); // lendo o cnpj referente da classe pessoa
                if (string.IsNullOrEmpty(pessoa.cnpj))
                {
                    throw new Exception("Não pode haver cnpj nulo ou vazio.");
                }
                Console.WriteLine("Digite o Nome: "); // pedindo para informa o nome
                pessoa.nome = Console.ReadLine(); // lendo o nome referente da classe pessoa
                if (string.IsNullOrEmpty(pessoa.nome))
                {
                    throw new Exception("Não pode haver nome nulo ou vazio.");
                }
                if (char.IsNumber(pessoa.nome, 0))
                {
                    throw new Exception("Nome do produto não pode ser numero");
                }
                Console.WriteLine("Digite a idade: "); // pedindo a idade do comprado  
                string idade = Console.ReadLine();
                if (!char.IsNumber(idade, 0))
                {
                    throw new Exception("Idade Invalida");
                }
                if (int.TryParse(idade, out int valor)) // le um valor e verifica se é um numero inteiro
                {
                    pessoa.idade = Math.Abs(valor); // atribui para n o valor digitado 
                }

            }

        }
        public List<Pessoa> GetPessoa { get; set; } = new List<Pessoa>(); // instancia o metodo getPessoa
    }
}
