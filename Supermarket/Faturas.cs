using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Supermarket
{
    class Faturas
    { 
         public List<Fatura> listaDeFaturas;

        public Faturas()
        {
            listaDeFaturas = new List<Fatura>();
        }

       
        public void guardarFaturas()
        {
            string localizacaoFicheiro = Directory.GetCurrentDirectory();
            string nomeFicheiro = "faturasGuardadas.txt";

            //Criar a fatura
            FileStream filestream = File.Create(nomeFicheiro);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            foreach (Fatura faturaASerLido in listaDeFaturas)
            {
                binaryFormatter.Serialize(filestream, faturaASerLido);
            }
            binaryFormatter.Serialize(filestream, listaDeFaturas);

            filestream.Close();

        }
           


    }
}
