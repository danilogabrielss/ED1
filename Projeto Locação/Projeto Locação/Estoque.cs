using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Locação
{
    class Estoque
    {
        public int id { get; set; }
        public string nomeEquip { get; set; }
        public Queue<Equipamento> equipamentos = new Queue<Equipamento>();
        /*public Queue<Equipamento> Equipamentos
        {
            get => equipamentos;
        }*/
        public Estoque() { }
        public Estoque(int id, string nomeEquip)
        {
            this.id = id;
            this.nomeEquip = nomeEquip;
        }
        public void emprestarEquipamento()
        {
            equipamentos.Dequeue();
        }
        public void devolverEquipamento(Equipamento equip)
        {
            this.equipamentos.Enqueue(equip);
        }
        public Equipamento pesquisarEquipamento(Equipamento equip)
        {
            foreach (Equipamento e in equipamentos)
            {
                if (e.id == equip.id)
                {
                    return e;
                }
            }
            return null;
        }
        public string listarLiberados()
        {
            string retorno = "";
            foreach (Equipamento e in equipamentos)
            {
                if (e.avariado == false)
                {
                    retorno += e.ToString();
                }
            }
            return retorno;
        }
        public string ToString()
        {
            string equip = "";
            foreach (Equipamento e in equipamentos)
            {
                equip += e.ToString();
            }
            return "Id: " + id + ", Tipo do Equipamento: " + nomeEquip + "Equipamentos: " + equip;
        }
    }
}