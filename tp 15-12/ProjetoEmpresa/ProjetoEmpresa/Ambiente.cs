using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEmpresa
{
    class Ambiente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Queue<Log> logs { get; set; }
        public Ambiente()
        {
            this.logs = new Queue<Log>();
        }
        public Ambiente(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
            this.logs = new Queue<Log>();
        }
        public void registrarLog(Log log)
        {
            logs.Enqueue(log);
            if (logs.Count >= 100)
            {
                logs.Dequeue();
            }
        }
        public override string ToString()
        {
            return "\nAmbiente id=" + this.id+"\nNome= " + this.nome;
        }
    }
}
