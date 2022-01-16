using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Transporte
{
    class Garagem
    {
        public int id { get; set; }
        public string local { get; set; }
        private Stack<Veiculo> veiculos = new Stack<Veiculo>();
        public Garagem() { }
        public Stack<Veiculo> Veiculos
        {
            get { return veiculos; }
        }
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
            foreach(Veiculo v in veiculos)
            {
                retorno += v.lotacao;
            }
            return retorno;
        }

    }
}
