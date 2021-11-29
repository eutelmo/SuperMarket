using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Supermarket
{
    class Funcionarios
    {
        public List<Funcionario> listaDeFuncionarios;

        public Funcionarios()
        {
            listaDeFuncionarios = new List<Funcionario>();
        }

        //============================================================|Guardar Funcionario|================================================
        
        #region GuardarFuncionario
        public void saveFuncionario()
        {
            string localizacaoFicheiro = Directory.GetCurrentDirectory();
            string nomeFicheiro = "funcionariosGuardados.txt";

            //Validação da existencia do ficheiro
            if (File.Exists(nomeFicheiro))
            {
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine("|O ficheiro antigo foi apagado e substituido por um Ficheiro atualizado|");
                Console.WriteLine("|______________________________________________________________________|");

                File.Delete(nomeFicheiro);
            }

            //Criacao do ficheiro
            FileStream filestream = File.Create(nomeFicheiro);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            foreach (Funcionario funcionarioASerLido in listaDeFuncionarios)
            {
                binaryFormatter.Serialize(filestream, funcionarioASerLido);
            }
            binaryFormatter.Serialize(filestream, listaDeFuncionarios);

            filestream.Close();

        }
        #endregion

        //============================================================|Ler Funcionario|====================================================

        #region LerFuncionario
        public void leituraFuncionario()
        {
            string nomeFicheiro = "funcionariosGuardados.txt";

            if (File.Exists(nomeFicheiro))
            {
                FileStream fileStream = File.OpenRead(nomeFicheiro);
                BinaryFormatter binaryFormatter = new BinaryFormatter();


                while (fileStream.Position < fileStream.Length)
                {
                    Funcionario funcionarioLido = binaryFormatter.Deserialize(fileStream) as Funcionario;
                    listaDeFuncionarios.Add(funcionarioLido);
                }

                fileStream.Close();
            }
            else
            {
                Console.WriteLine("__________________________________________________________");
                Console.WriteLine("|O ficheiro não foi encontrado, por favor crie um ficheiro|");
                Console.WriteLine("|_________________________________________________________|");
            }
        }
        #endregion

        //============================================================|Login|==============================================================
        
        #region Login
        public TipoFuncionarios login(string nomeRecebido, string passRecebida)
        {
            foreach (Funcionario item in listaDeFuncionarios)
            {
                if(item.nome == nomeRecebido)
                {
                    if (item.codFuncionario == int.Parse(passRecebida))
                    {
                        return item.tFuncionarios;
                    }
                }
            }
            return TipoFuncionarios.Indefenido;
        }
        #endregion

        //============================================================|Metodo ToString()|==================================================

        #region ToString
        public override string ToString()
        {
            string result = "";
            foreach (Funcionario f in this.listaDeFuncionarios)
            {
                result += "|Nome do Funcionario: " + f.nome + " |Palavra-Passe: " + f.codFuncionario + " |Data de Nascimento: " + f.dataNascimento + " |Tipo de Funcionario: " + f.tFuncionarios + "\n";
            }
            return result;
        }
        #endregion

        //============================================================|Apagar Funcionario|=================================================

        #region ApagarFuncionario
        public bool apagarFuncionario(string nome)
        {
            int indexARemover = -1;

            for (int i = 0; i < this.listaDeFuncionarios.Count; i++)
            {
                if (this.listaDeFuncionarios[i].nome.ToLower().Equals(nome.ToLower())){

                    indexARemover = i;
                }
            }

            if(indexARemover != -1)
            {
                this.listaDeFuncionarios.RemoveAt(indexARemover);
                saveFuncionario();
                return true;
            }

            return false;

        }
        #endregion











    }
}
