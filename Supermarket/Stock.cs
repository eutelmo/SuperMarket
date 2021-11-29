using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;


namespace Supermarket
{
    [Serializable]
    class Stock
    {
        //lista de Produtos
        public List<Peixe> listaPeixes;
        public List<Carne> listaCarne;
        public List<Fruta> listaFruta;

        public Stock()
        {
            listaPeixes= new List<Peixe>();
            listaCarne = new List<Carne>();
            listaFruta = new List<Fruta>();
        }

        //============================================================|Guardar Produto|================================================

        #region saveProduto
        public void saveProduto()
        {
            string localizacaoFicheiro = Directory.GetCurrentDirectory();
            string nomeFicheiro = "produtosGuardados.txt";

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

            
            binaryFormatter.Serialize(filestream, this);

            filestream.Close();
        }
        #endregion

        #region Leitura De Produto
        static public Stock leituraProdutos()
        {
            string nomeFicheiro = "produtosGuardados.txt";
            Stock s = new Stock();

            if (File.Exists(nomeFicheiro))
            {
                FileStream fileStream = File.OpenRead(nomeFicheiro);
                BinaryFormatter binaryFormatter = new BinaryFormatter();


                s = binaryFormatter.Deserialize(fileStream) as Stock;

                return s;

                fileStream.Close();
            }
            else
            {
                Console.WriteLine("__________________________________________________________");
                Console.WriteLine("|O ficheiro não foi encontrado, por favor crie um ficheiro|");
                Console.WriteLine("|_________________________________________________________|");
                return null;

            }


        }
        #endregion

        #region Apagar Elemento Lista
        public bool apagarLista(string nome)
        {
            int index = -1;
            int tipo;
            foreach (Carne i in this.listaCarne)
            {
                if (i.Marca==nome)
                {
                    index = this.listaCarne.IndexOf(i) ;
                    
                }


            }

            if (index >=0)
            {
                this.listaCarne.RemoveAt(index);
                return true;
            }
            


            foreach (Peixe i in this.listaPeixes)
            {
                if (i.Marca == nome)
                {
                    index = this.listaPeixes.IndexOf(i);

                }


            }
            if (index >= 0)
            {
                this.listaPeixes.RemoveAt(index);
                return true;
            }
            index = -1;


            foreach (Fruta i in this.listaFruta)
            {
                if (i.Marca == nome)
                {
                    index = this.listaFruta.IndexOf(i);

                }


            }
            if (index >= 0)
            {
                this.listaFruta.RemoveAt(index);
                return true;
            }
            index = -1;
            return false;

        }
        #endregion

        #region ToString
        public override string ToString()
        {
            string result = "";
            foreach(Peixe px in this.listaPeixes)
            {

                result += px;
            }

            foreach (Carne br in this.listaCarne)
            {

                result += br;
            }

            foreach (Fruta lr in this.listaFruta)
            {

                result += lr;
            }
            return base.ToString();
       }
        #endregion
    }
}
