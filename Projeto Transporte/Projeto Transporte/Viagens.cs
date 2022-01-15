using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Transporte
{
    class Viagens
    {
        public Queue<Viagem> viagens { get; set; }
        public void incluir(Viagem viagem)
        {
            viagens.Enqueue(viagem);
        }
    }
}
