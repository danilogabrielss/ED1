using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Transporte
{
    class Viagens
    {
        public Queue<Viagem> viagens;
        public Viagens()
        {
            this.viagens = new Queue<Viagem>();
        }
        public void incluir(Viagem viagem)
        {
            viagens.Enqueue(viagem);
        }
        public Queue<Viagem> Viagenss
        {
            get { return viagens; }
        }
    }
}
