using System;
using System.Collections.Generic;

namespace Salarios
{
    class Program
    {
        static void Main(string[] args)
        {

            //Colocando o número de funcionários
            Console.WriteLine("Digite o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            //Criando lista de funcionários
            List<Funcionario> funcionarios = new List<Funcionario>();

            //Aqui eu tentei criar de algum jeito que o ID não se repetisse
            //int id2 = 0;

            //Criando uma estrututra de repetição para colocar os valores em cada funcionarios
            for (int i = 0; i < n; i++)
            {
                //Pedindo e colocando o ID
                Console.WriteLine("Digite o Id: ");
                int id = int.Parse(Console.ReadLine());

                /*if (id == id2)
                {
                    Console.WriteLine("\nId já existente!");      
                }*/

                //Pedindo e colocando o nome
                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();

                //Pedindo e colocando o salário
                Console.WriteLine("Digite o salário: ");
                double salario = double.Parse(Console.ReadLine());
                //id2 = id;

                //Colocando todos os valores de todas as variaveis em um funcionario
                funcionarios.Add(new Funcionario { Id = id, Nome = nome, Salario = salario });

            }

            //Pedindo e colocando o ID para pesquisa
            Console.WriteLine("Digite o id do funcionário: ");
            int idFunc = int.Parse(Console.ReadLine());

            //Encontrando o funcionario pelo ID
            var func = funcionarios.Find(x => x.Id == idFunc);

            //Comparando se o ID é diferente de nulo
            if (func != null)
            {
                //Pedindo e colocando a porcetagem
                Console.WriteLine("Digite a porcentagem: ");
                double porc = double.Parse(Console.ReadLine());
                //Chamando a funcão incrementar salário
                func.incrementarSalario(porc);
            }
            else
            {
                //Informando que o ID não existe
                Console.WriteLine("Id inexistente!");
            }

            //Pulando linha
            Console.WriteLine();
            //Imprimindo autalização
            Console.WriteLine("Atualização:");

            //Para cada item da lista imprimindo seus valores
            foreach (var item in funcionarios)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Salario);
                Console.WriteLine("--------------");
            }
        }
    }
}
