using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atendimento
{
    class Guiche
    {
        public int id { get; set; }
        public Queue<Senha> atendimentos { get; set; }
        public Guiche()
        {
            this.atendimentos = new Queue<Senha>();
            this.id = 0;
        }

        public Guiche(int id)
        {
            this.id = id;
            this.atendimentos = new Queue<Senha>(id);
        }
        public bool chamar(Queue<Senha> filaSenha)
        {
            if (filaSenha == null)
            {
                return false;
            }
            else
            {
                Senha senha = filaSenha.Dequeue();
                senha.dataAtend = DateTime.Now;
                senha.horaAtend = DateTime.Now;
                atendimentos.Enqueue(senha);
                return true;
            }
        }
    }
}
