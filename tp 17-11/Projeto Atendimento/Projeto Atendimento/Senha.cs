using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atendimento
{
    class Senha
    {
        public int id { get; set; }
        public DateTime dataGerac { get; set; }
        public DateTime horaGerac { get; set; }
        public DateTime dataAtend { get; set; }
        public DateTime horaAtend { get; set; }

        public Senha() { }
        public Senha(int id)
        {
            this.id = id;
            this.dataGerac = DateTime.Now;
            this.horaGerac = DateTime.Now;
        }
        public string dadosParciais()
        {
            return this.id + "-" + this.dataGerac.ToString("dd/MM/yyyy") + "-" + this.horaGerac.ToString("HH:mm:ss");
        }
        public string dadosCompletos()
        {
            return this.id + "-" + this.dataGerac.ToString("dd/MM/yyyy") + "-" + this.horaGerac.ToString("HH:mm:ss") + " // " + this.dataAtend.ToString("dd:MM:yyyy") + "-" + this.horaAtend.ToString("HH:mm:ss");
        }
    }
}
