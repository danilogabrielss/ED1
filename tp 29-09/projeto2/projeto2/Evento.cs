using System;
using System.Collections.Generic;
using System.Text;

namespace projeto2
{
    class Evento
    {
        private int id;
        private string descricao;
        private int qtdeMaxParticipantes;
        private Participante[] participantes;

        public Evento()
        : this(0, "", 0, new Participante[900])
        { }
        public Evento(int id, string descricao, int qtdeMaxParticipantes, Participante[] p)
        {
            this.id = id;
            this.descricao = descricao;
            this.qtdeMaxParticipantes = qtdeMaxParticipantes;
            this.participantes = new Participante[qtdeMaxParticipantes];
            for (int i = 0; i < this.qtdeMaxParticipantes; ++i)
            {
                this.participantes[i] = new Participante();
            }
        }
        int i = 0;
        public int inscreverParticipante(Participante p)
        { 
            if (i < this.QtdeMaxParticipantes)
            {
                this.participantes[i] = p;
                i++;
                return 0;
            }
            else
            {
                return 1;
            }
            int participando = 0;
            for (int j = 0; j < this.QtdeMaxParticipantes; ++j)
            {
                if (p.Email != "")
                {
                    participando++;
                }
            }
            if (participando >= 2)
                return 2;
        }
        public int qtdeParticipantes()
        {
            int totalParticipantes = 0;
            foreach (Participante p in participantes)
            {
                if (p.Nome != "")
                {
                    totalParticipantes++;
                }
            }
            return totalParticipantes;
        }

        public string listaParticipantes()
        {
            string listar = "";
            foreach (Participante p in participantes)
            {
                if (p.Email != "")
                    listar += (p.toString());
            }
            return listar;
        }

        public override bool Equals(object obj)
        {
            return this.id.Equals(((Evento)obj).id);
        }
        public string toString()
        {
            return "Id:" + this.id + "\nDescricao: " + this.descricao +
                "\nQuantidade máxima de participantes: " + this.qtdeMaxParticipantes;
        }

        /*public override int GetHashCode()
        {
            return base.GetHashCode();
        }*/

        public override string ToString()
        {
            return base.ToString();
        }

        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { this.descricao = value; }
        }
        public int QtdeMaxParticipantes
        {
            get { return qtdeMaxParticipantes; }
        }
        public Participante[] Participantes
        {
            get { return participantes; }
            set { this.participantes = value; }
        }
    }
}
