using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    enum TipoFatura
    {
        FaturaSimples,
        FaturaContribuinte
    }
    class Fatura
    {
        public int idFatura;
        public string dataEmissao;
        public TipoFatura tFatura;

        public Fatura(int idFatura, string dataEmissao, TipoFatura tFatura)
        {
            this.idFatura = idFatura;
            this.dataEmissao = dataEmissao;
            this.tFatura = tFatura;
        }
    }
}
