using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Transporte
{
    class Garagens
    {
        public List<Garagem> garagens { get; set; }
        public bool jornadaAtiva { get; set; }
        public Garagens(){garagens = new List<Garagem>();}
        public Garagens(bool jornadaAtiva)
        {
            //garagens = new List<Garagem>();
            this.jornadaAtiva = jornadaAtiva;
        }
        public void incluir(Garagem garagem)
        {
            garagens.Add(garagem);
        }
        public void iniciarJornada()
        {
            jornadaAtiva = true;
        }
        /*public List<Transporte> encerrarJornada()
        {

        }*/
    }
}
