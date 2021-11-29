using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    class Gerente : Funcionario
    {
        //Class Filho de Funcionario

        #region construtor
        public Gerente(string nome, int codFuncionario, string dataNascimento, TipoFuncionarios tFuncionarios) : base(nome, codFuncionario, dataNascimento, tFuncionarios)
        {

        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return "|Nome do Funcionario: " + nome + " |Palavra-Passe: " + codFuncionario + " |Data de Nascimento: " + dataNascimento + 
                " |Tipo de Funcionario: " + tFuncionarios;
        }
        #endregion

    }
}
