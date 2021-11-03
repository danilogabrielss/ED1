using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto4
{
    class Livro
    {
        public int isbn { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string editora { get; set; }
        public List<Exemplar> exemplares { get; set; }

        public Livro(int isbn, string titulo, string autor, string editora)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.exemplares = new List<Exemplar>();
        }
        public Livro()
        {
            this.exemplares = new List<Exemplar>();
        }
        public void adicionarExemplar(Exemplar exemplar)
        {
            exemplares.Add(exemplar);
        }
        public int qtdeExemplares()
        {
            return this.exemplares.Count;
        }
        public int qtdeDisponiveis()
        {
            int i = 0;
            foreach (Exemplar ex in exemplares)
            {
                if (ex.disponivel() == true)
                    i++;
            }
            return i;
        }
        public int qtdeEmprestimos()
        {
            int returnQtde = 0;
            foreach (Exemplar ex in exemplares)
            {
                if (ex.disponivel() == false)
                {
                    returnQtde++;
                }
            }
            return returnQtde;
        }
        public double percDisponibilidade()
        {
            if (qtdeDisponiveis() == 0)
                return 0;
            int i = 0;
            foreach (Exemplar ex in exemplares)
            {
                if (ex.disponivel() == true)
                    i++;
            }
            double tt = 0;
            tt = ((double)i / exemplares.Count) * 100;
            return ((double)Math.Round(tt, 2));
        }

        public string TooString()
        {
            return ("{ISBN=" + this.isbn + "}\n{Titulo=" + this.titulo + "}\n" +
                "{Autor=" + this.autor + "}\n{Editora=" + this.editora + "}\n" +
                "{Qdte de Exemplares " + this.qtdeExemplares() + "}\n" +
                "{Qdte de Disponiveis " + this.qtdeDisponiveis() + "}\n" +
                "{Qdte de Emprestimos " + this.qtdeEmprestimos() + "}\n" +
                "{Percentual disponivel " + this.percDisponibilidade() + "}");
        }
        public string toString()
        {
            string respExemplares = "";
            foreach (Exemplar ex in exemplares)
            {
                respExemplares += ex.ToString();
            }
            return ("{ISBN=" + this.isbn + "}\n{Titulo=" + this.titulo + "}\n" +
                "{Autor=" + this.autor + "}\n{Editora=" + this.editora + "}\n" +
                "{Qdte de Exemplares " + this.qtdeExemplares() + "}\n" +
                "{Qdte de Disponiveis " + this.qtdeDisponiveis() + "}\n" +
                "{Qdte de Emprestimos " + this.qtdeEmprestimos() + "}\n" +
                "{Percentual disponivel " + (double)this.percDisponibilidade() + "}\n" +
                "{Exemplares=" + respExemplares + "}\n");
        }
    }
}
