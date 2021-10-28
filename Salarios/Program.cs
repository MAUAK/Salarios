using System;
using System.Collections.Generic;

namespace Salarios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ----------------- KAUAM SILVA BATISTA - 210501 ----------- 
             */

            //Colocando o número de funcionários
            Console.WriteLine("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            //Criando lista de funcionários
            List<Funcionario> funcionarios = new List<Funcionario>();

            //Criando uma variavel para o id não repetir
            int id2 = 0;

            //Criando uma estrututra de repetição para colocar os valores em cada funcionarios
            for (int i = 0; i < n; i++)
            {
                //Declarando a variavel id
                int id = 0;

                //Criando uma estrutura de repetição para não repetir o id
                do
                {
                    //Imprimindo o funcionário com seu número
                    Console.WriteLine("\nFuncionário #" + (i + 1) + " : ");
                    //Pedindo e colocando o ID
                    Console.WriteLine("Digite o Id: ");
                    id = int.Parse(Console.ReadLine());

                    //Verificando se o id colocado é igual ao id antigo
                    if (id == id2)
                    {
                        Console.WriteLine("\nId já existente!");
                    }
                    //Enquanto o id antigo for igual ao id atual, essa ação irá se repetir
                } while (id2 == id);

                //Pedindo e colocando o nome
                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();

                //Pedindo e colocando o salário
                Console.WriteLine("Digite o salário: ");
                double salario = double.Parse(Console.ReadLine());

                //Colocando o valor do id antigo em uma vriavel
                id2 = id;

                //Colocando todos os valores de todas as variaveis em um funcionario
                funcionarios.Add(new Funcionario { Id = id, Nome = nome, Salario = salario });
            }

            //Pedindo e colocando o ID para pesquisa
            Console.WriteLine("\nId do funcionário receberá aumento: ");
            int idFunc = int.Parse(Console.ReadLine());

            //Encontrando o funcionario pelo ID
            var func = funcionarios.Find(x => x.Id == idFunc);

            //Comparando se o ID é diferente de nulo
            if (func != null)
            {
                //Pedindo e colocando a porcetagem
                Console.WriteLine("Porcentagem de aumento de salário: ");
                double porc = double.Parse(Console.ReadLine());
                //Chamando a funcão incrementar salário
                func.incrementarSalario(porc);
            }
            else
            {
                //Informando que o ID não existe
                Console.WriteLine("\nEste funcionário não existe!");
            }

            //Pulando linha
            Console.WriteLine();
            //Imprimindo autalização
            Console.WriteLine("\nLista atualizada dos funcionários: ");
            int t = 0;
            //Para cada item da lista imprimindo seus valores
            foreach (var item in funcionarios)
            {
                t++;
                Console.WriteLine("\nFuncionário #" + t + ": ");
                Console.WriteLine(item.Id + ", " + item.Nome + ", " + item.Salario);
                // Console.WriteLine(item.Nome);
                //Console.WriteLine("Salario: " + item.Salario);
                Console.WriteLine("--------------");
            }
        }
    }
}
