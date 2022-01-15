using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Transporte
{
    class Garagem
    {
        public int id { get; set; }
        public string local { get; set; }
        public Stack<Veiculo> veiculos { get; set; }
        public Garagem() { veiculos = new Stack<Veiculo>(); }

        public Garagem(int id, string local)
        {
            this.id = id;
            this.local = local;
        }
        public int qtdeDeVeiculos()
        {
            int retorno = veiculos.Count;
            return retorno;
        }
        public int potencialDeTransporte()
        {
            int retorno = 0;
            return retorno;
        }
    }
}
