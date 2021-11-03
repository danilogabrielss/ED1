using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto4
{
    class Emprestimo
    {
        public DateTime dtEmprestimo { get; set; }
        public DateTime dtDevolucao { get; set; }

        public Emprestimo() { }
        public Emprestimo(DateTime dtEmprestimo, DateTime dtDevolucao)
        {
            this.dtEmprestimo = dtEmprestimo;
            this.dtDevolucao = dtDevolucao;
        }

        public override string ToString()
        {
            return "{Data de emprestimo=" + dtEmprestimo.ToString("dd/MM/yyyy") + "}\n" +
                "Data de devolucao=" + dtDevolucao.ToString("dd/MM/yyyy") + "}";
        }
    }
}
