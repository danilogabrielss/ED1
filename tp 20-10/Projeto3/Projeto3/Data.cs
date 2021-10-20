using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto3
{
    class Data
    {
        public int dia { get; set; }
        public int mes { get; set; }
        public int ano { get; set; }

        public Data() 
        {
            this.dia = 0;
            this.mes = 0;
            this.ano= 0;
        }
        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
        public override string ToString()
        {
            return (this.dia + "/" + this.mes + "/" + this.ano);
        }
        public void setData(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
    }
}
