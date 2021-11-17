using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atendimento
{
    class Guiches
    {
        public List<Guiche> listaGuiches { get; set; }
        public Guiches()
        {
            this.listaGuiches = new List<Guiche>();
        }
        public void adicionar(Guiche guiche)
        {
            listaGuiches.Add(guiche);
        }
    }
}
