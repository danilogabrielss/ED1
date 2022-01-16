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
        public override bool Equals(object obj)
        {
            Viagem viagem = (Viagem)obj;
            return viagem.id.Equals(id);
        }
        public override string ToString()
        {
            return "Id: " + id + ", Origem: " + origem.ToString()+ ", Destino: " + destino.ToString()+ "\nVeículo - " + veiculo.ToString();
        }
    }
}
