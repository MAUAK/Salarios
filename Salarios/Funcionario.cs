using System;
using System.Collections.Generic;
using System.Text;

namespace Salarios
{
    class Funcionario
    {
        //Criando a variavel id com encapsulamento
        public int Id { get; set; }
        //Criando a variavel nome com encapsulamento
        public string Nome { get; set; }
        //Criando a variavel salario com encapsulamento
        public double Salario { get; set; }

        //Criando o método para incrementar a porcentagem ao salario
        public void incrementarSalario(double porcentagem)
        {
            Salario += (Salario/porcentagem);
        }
    }
}
