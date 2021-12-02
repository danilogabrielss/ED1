using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Medicamento
{
    class Medicamento
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string laboratorio { get; set; }
        public Queue<Lote> lotes { get; }
        public Medicamento()
        {
            this.lotes = new Queue<Lote>();
        }

        public Medicamento(int id, string nome, string laboratorio)
        {
            this.id = id;
            this.nome = nome;
            this.laboratorio = laboratorio;
            this.lotes = new Queue<Lote>();
        }
        public int qtdeDisponivel()
        {
            int ret = 0;
            foreach (Lote l in lotes)
            {
                ret += l.qtde;
            }
            return ret;
        }
        public void comprar(Lote lote)
        {
            lotes.Enqueue(lote);
        }
        public bool vender(int qtde)
        {
            if (qtde >= this.qtdeDisponivel())
            {
                foreach (Lote l in lotes)
                {
                    l.qtde -= qtde;
                    if (l.qtde == 0)
                    {
                        lotes.Dequeue();
                    }
                    if (qtde == 0)
                    {
                        return true;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public string toString()
        {
            return "{id= " + this.id + " nome= " + nome + " lab= " + laboratorio + " qtdeDisponivel= " + qtdeDisponivel() +" }";
        }
        public string tooString()
        {
            string retorno = "";
            foreach (Lote lt in lotes)
            {
                retorno += lt.toString();
            }
            return "{id= " + this.id + " nome= " + nome + " lab= " + laboratorio + " qtdeDisponivel= " + qtdeDisponivel() + "\nLotes = " + retorno +" }\n";
        }
        public override bool Equals(object obj)
        {
            Medicamento medicamento= (Medicamento)obj;
            if (medicamento.id == id)
            {
                return true;
            }
            return false;
        }
    }
}
