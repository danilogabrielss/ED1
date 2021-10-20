using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Contatos
    {
        public List<Contato> agenda { get; }

        public Contatos()
        {
            this.agenda = new List<Contato>();
        }
        public bool adicionar(Contato c)
        {
            if (Equals(c))
            {
                return false;
            }
            agenda.Add(c);
            return true;
        }
        public Contato pesquisar(Contato c)
        {
            foreach (Contato contato in agenda)
            {
                if (c.email == contato.email)
                {
                    return contato;
                }
            }
            return null;
        }
        public bool alterar(Contato c)
        {
            bool podeAlterar = false;
            foreach (Contato ct in agenda)
            {
                if (this.Equals(c))
                {
                    Console.Write("Digite o telefone a ser alterado: ");
                    c.telefone = Console.ReadLine();
                    podeAlterar = true;
                }
            }
            return podeAlterar;
        }
        public bool remover(Contato c)
        {
            foreach (Contato contato in agenda)
            {
                if (contato.email == c.email)
                {
                    agenda.Remove(contato);
                    return true;
                }
            }
            return false;
            /*if (Equals(c))
            {
                return false;
            }
            agenda.Add(c);
            return true;
            */
        }
        public override bool Equals(object obj)
        {
            return this.agenda.Equals(((Contato)obj).email);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
