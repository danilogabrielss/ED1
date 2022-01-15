using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Locação
{
    class Contratos
    {
        public Stack<Contrato> contratos { get; set; }
        public Contratos() { this.contratos = new Stack<Contrato>(); }

        public void adicionarContrato(Contrato contrato)
        {
            contratos.Push(contrato);
        }
        public string listarContato(Contrato contat)
        {
            string retorno = "";
            foreach (Contrato c in contratos)
            {
                retorno += c.ToString();
            }
            return retorno;
        }
        public Contrato pesquisarContrato(Contrato contrato)
        {
            foreach (Contrato c in contratos)
            {
                if (c.id == contrato.id)
                {
                    return c;
                }
            }
            return null;
        }
    }
}
