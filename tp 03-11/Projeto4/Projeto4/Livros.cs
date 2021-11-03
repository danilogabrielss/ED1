using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto4
{
    class Livros
    {
        public List<Livro> acervo { get; set; }

        public Livros()
        {
            this.acervo = new List<Livro>();
        }

        public Livros(List<Livro> acervo)
        {
            this.acervo = acervo;
        }

        public void adicionar(Livro livro)
        {
            acervo.Add(livro);
        }
        public Livro pesquisar(Livro livro)
        {
            foreach (Livro li in acervo)
            {
                if (li.isbn == livro.isbn)
                {
                    return li;
                }
            }
            return null;
        }
    }
}
