using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Transporte
{
    class Viagem
    {
        public readonly int id = 0;// { get; set; }
        public Garagem origem { get; set; }
        public Garagem destino { get; set; }
        public Veiculo veiculo { get; set; }
        public Viagem() { }
        public Viagem(Garagem origem, Garagem destino, Veiculo veiculo)
        {
            id++;
            this.origem = origem;
            this.destino = destino;
            this.veiculo = veiculo;
        }
    }
}
