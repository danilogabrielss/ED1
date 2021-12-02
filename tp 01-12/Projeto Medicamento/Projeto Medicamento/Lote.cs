using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Medicamento
{
    class Lote
    {
        public int id { get; set; }
        public int qtde { get; set; }
        public DateTime venc { get; set; }
        public Lote() {
            id = 0;
        }
        public Lote(int qtde, DateTime venc)
        {
            id++;
            this.qtde = qtde;
            this.venc = venc;
        }
        public string toString()
        {
            return "{Lote= id="+ this.id + " qtde=" + this.qtde + " venc=" +this.venc.ToString("dd/MM/yyyy" + " }");
        }
    }
}
