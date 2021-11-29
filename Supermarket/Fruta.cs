using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    [Serializable]
    enum TipoDeFruta
    {
        Maca,
        Banana,
        Pessego,
        Ananas,
        Malancia
    }
    [Serializable]
    class Fruta :Produto
    {
        public TipoDeFruta tFruta;

        #region construtor
        public Fruta(string marca, float preco, bool disponibilidade, int quantidade, bool vegan, TipoDeFruta tFruta) : base(marca, preco, disponibilidade, quantidade, vegan)
        {

            this.Marca = marca;
            this.Preco = preco;
            Disponibilidade = true;
            this.Quantidade = quantidade;
            Vegan = true;
            this.tFruta = tFruta;
        }
        #endregion


        #region ToString
        public override string ToString()
        {
            string result = "";

            result += "|Nome do Produto: " + this.tFruta.ToString() + " |Preco: " + this.Preco.ToString() + "|Disponibilidade: " + this.Disponibilidade.ToString() + "|Quantidade: " + this.Quantidade.ToString() + "|Vegan: " + this.Vegan.ToString() + "\n";


            return result;
        }
        #endregion
    }
}
