using System;
using System.Collections.Generic;
using System.Text;

namespace projeto2
{
    class Eventos
    {
        private Evento[] osEventos;
        public Eventos()
        : this(new Evento[7])
        { }
        public Eventos(Evento[] e)
        {
            this.osEventos = new Evento[7];
            for (int i = 0; i < 7; ++i)
            {
                this.osEventos[i] = new Evento();
            }
        }

        public bool adicionarEvento(Evento e)
        {
            bool podeAdd = (e.Id <= 7);
            if (podeAdd == true)
            {
                e = this.osEventos[e.Id];
            }
            return podeAdd;
        }
        public string pesquisarParticipante(Participante p)
        {
            for (int i = 0; i < qtdeParticipantes(); i++)
            {
                foreach (Participante participante in osEventos[i].Participantes)
                {
                    if (participante.Equals(p))
                    {
                        return "Encontrado";
                    }
                }
            }
            return "Não encontrado";
        }
        public int qtdeParticipantes()
        {
            int totalParticipantes = 0;
            foreach (Evento e in this.osEventos)
            {
                totalParticipantes += e.qtdeParticipantes();
            }
            return totalParticipantes;
        }
        public string listaEventos()
        {
            string listar = "";
            foreach (Evento e in osEventos)
            {
                listar += e.toString();
            }
            return listar;
        }

        public Evento[] OsEventos
        {
            get { return this.osEventos; }
            set { this.osEventos = value; }
        }
    }
}
