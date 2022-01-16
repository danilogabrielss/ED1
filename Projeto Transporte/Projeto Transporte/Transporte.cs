using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Transporte
{
    class Transporte
    {
        public Veiculo veiculo { get; set; }
        public int qtdeTransportada { get; set; }
        public Transporte() { }
        public Transporte(Veiculo veiculo, int qtde)
        {
            this.veiculo = veiculo;
            this.qtdeTransportada = qtde;
        }
    }
}
