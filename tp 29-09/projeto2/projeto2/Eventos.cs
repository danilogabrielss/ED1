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
        public string pesquisarParticipante(Participante[] p)
        {            
            string achou = "";
            Console.Write("Digite o email da pessoa a ser procurada: ");
            string search = Console.ReadLine();
            for (int k = 0; k < 900; k++)
            {
                if (p[k].Email == search)
                    p[k].Nome = achou;                
            }
            if (achou == "")
                achou = "Não encontrado";
            return achou;
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
