using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Medicamento
{
    class Medicamentos
    {
        public List<Medicamento> listaMedicamentos { get; set; }
        public Medicamentos()
        {
            this.listaMedicamentos = new List<Medicamento>();
        }
        public void adicionar(Medicamento medicamento)
        {
            listaMedicamentos.Add(medicamento);
        }
        public bool deletar(Medicamento medicamento)
        {
            if (medicamento.qtdeDisponivel() == 0)
            {
                listaMedicamentos.Remove(medicamento);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Medicamento pesquisar(Medicamento medicamento)
        {
            foreach (Medicamento med in listaMedicamentos)
            {
                if (medicamento.id == med.id)
                {
                    return med;
                }
            }
            return null;
        }
    }
}
