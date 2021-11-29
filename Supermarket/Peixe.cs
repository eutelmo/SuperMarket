using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    [Serializable]
    enum TipoDePeixe
    {
        Salmao,
        Robalo,
        Sardinha,
        Bacalhau

    }
    [Serializable]
    class Peixe : Produto
    {

        public TipoDePeixe tPeixe;


        #region Construtor
        public Peixe(string marca, float preco, bool disponibilidade, int quantidade, bool vegan, TipoDePeixe tPeixe) : base(marca, preco, disponibilidade, quantidade, vegan)
        {
            this.Marca = marca;
            this.Preco = preco;
            Disponibilidade = true;
            this.Quantidade = quantidade;
            Vegan = false;
            this.tPeixe = tPeixe;

        }
        #endregion

        #region ToString
        public override string ToString()
        {
            string result = "";

            result += "|Nome do Produto: " + this.tPeixe.ToString() + " |Preco: " + this.Preco.ToString() + "|Disponibilidade: " + this.Disponibilidade.ToString() + "|Quantidade: " + this.Quantidade.ToString() + "|Vegan: " + this.Vegan.ToString() + "\n";


            return result;
        }
        #endregion
       

    }
}
