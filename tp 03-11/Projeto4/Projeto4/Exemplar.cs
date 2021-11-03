using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto4
{
    class Exemplar
    {
        public int tombo { get; set; }
        public List<Emprestimo> emprestimos { get; set; }
        public Exemplar()
        {
            this.emprestimos = new List<Emprestimo>();
        }

        public Exemplar(int tombo)
        {
            this.tombo = tombo;
            this.emprestimos = new List<Emprestimo>();
        }

        public bool emprestar()
        {
            if (disponivel() == true)
            {
                emprestimos.Add(new Emprestimo(DateTime.UtcNow,DateTime.UtcNow.AddMonths(1)));
                return true;
            }
            return false;
        }
        public bool devolver()
        {
            foreach (Emprestimo e in emprestimos)
            {
                if (DateTime.Now >= e.dtEmprestimo && DateTime.Now <= e.dtDevolucao)
                {
                    emprestimos.Remove(e);
                    return true;
                }
            }
            return false;
        }
        public bool disponivel()
        {
            if (emprestimos.Count == 0)
            {
                return true;
            }
            else
            {
                foreach (Emprestimo e in emprestimos)
                {
                    if (e.dtEmprestimo != null && e.dtDevolucao == null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public int qtdeEmprestimos()
        {
            return emprestimos.Count;
        }
        public override string ToString()
        {
            string emprestimoReturn = "";
            foreach (Emprestimo em in emprestimos)
            {
                emprestimoReturn += em.ToString();
            }
            return ("\n{Tombo do exemplar=" + this.tombo + "}\n" +
                "{Emprestimo=" + emprestimoReturn + "}");
        }
    }
}
