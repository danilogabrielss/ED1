using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Transporte
{
    class Garagens
    {
        public List<Garagem> garagens { get; set; }
        public List<Transporte> transportes { get; set; }
        public bool jornadaAtiva { get; set; }
        public Garagens()
        {
            garagens = new List<Garagem>();
            jornadaAtiva = false;
            transportes = new List<Transporte>();
        }
        public void incluir(Garagem garagem)
        {
            garagens.Add(garagem);
        }
        public void iniciarJornada()
        {
            transportes.Clear();
            jornadaAtiva = true;
        }
        public List<Transporte> encerrarJornada()
        {
            jornadaAtiva = false;
            return transportes;
        }
        public Garagem pesquisarGaragem(Garagem garagem)
        {
            foreach (Garagem g in garagens)
            {
                if (g.Equals(garagem))
                {
                    return g;
                }
            }
            return null;
        }
    }
}
