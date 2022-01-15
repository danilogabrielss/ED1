using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Locação
{
    class Equipamento
    {
        public int id { get; }
        public bool avariado { get; set; }
        public float taxaDiaria { get; set; }
        public string ToString()
        {
            return "id: " + this.id + "Avariado: " + this.avariado + "Taxa diaria: " + this.taxaDiaria;
        }
        public Equipamento() { }
        public Equipamento(bool avariado, float taxaDiaria)
        {
            this.id++;
            this.avariado = avariado;
            this.taxaDiaria = taxaDiaria;
        }
    }
}
