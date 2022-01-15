using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Locação
{
    class Contrato
    {
        public int id { get; set; }
        public int qtdeSolicitada { get; set; }
        public DateTime dataSaida { get; set; }
        public DateTime dataRetorno { get; set; }
        public List<Estoque> estoques = new List<Estoque>();
        public Contrato(){}
        public Contrato(int id, int qtdeSolicitada)
        {
            this.id = id;
            this.qtdeSolicitada = qtdeSolicitada;
            dataSaida = dataSaida.AddYears(4000);
            dataRetorno = dataRetorno.AddYears(4000);
        }
        public bool liberarContrato(Estoque estoque)
        {
            if (estoques.Count != 0)
            {
                dataSaida = DateTime.Now;
                estoque.emprestarEquipamento();
                return true;
            }
            return false;
        }
        public void devolverEquipamentos(Estoque estoque, Equipamento equip)
        {
            if (estoques.Count == 0)
            {
                dataRetorno = DateTime.Now;
                estoque.devolverEquipamento(equip);
            }
        }
        public void adicionarTipoEquipamento(Estoque estoque)
        {
            estoques.Add(estoque);
        }
        public Estoque pesquisarTipoEquipamento(Estoque estoque)
        {
            foreach (Estoque e in estoques)
            {
                if (e.id == estoque.id)
                {
                    return e;
                }
            }
            return null;
        }
        public string ToString()
        {
            string retorno = "";
            foreach (Estoque e in estoques)
            {
                retorno += e.ToString();
            }
            return "id: " + this.id +
                ", dataSaida: " + dataSaida +
                ", dataRetorno: " + dataRetorno +
                ", Equip. solicitados: " + retorno;
        }
    }
}
