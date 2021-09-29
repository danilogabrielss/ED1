using System;
using System.Collections.Generic;
using System.Text;

namespace projeto2
{
    class Participante
    {
        private string email;
        private string nome;

        public Participante()
        : this ("", "")
        { }

        public Participante(string email, string nome)
        {
            this.email = email;
            this.nome = nome;
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public bool podeInscrever(Eventos e)
        {
            Console.Write("Digite o numero do ID do evento: ");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a < 1 || a > 6)
            {
                Console.Write("Digite o numero do ID do evento: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            bool podeInscreve = (e.qtdeParticipantes() < e.OsEventos[a].QtdeMaxParticipantes);
            return podeInscreve;
        }

        public override bool Equals(object obj)
        {
            return this.email.Equals(((Participante)obj).email);
        }

        public string toString()
        {
            return "[[Email:" + email + "] [Nome: " + nome + "]]\n";
        }

        /*public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }*/
    }
}