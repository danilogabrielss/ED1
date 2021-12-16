using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEmpresa
{
    class Log
    {
        public DateTime dtAcesso { get; set; }
        public Usuario usuario { get; set; }
        public bool tipoAcesso { get; set; }
        public Log() { }

        public Log(Usuario usuario, bool tipoAcesso)
        {
            this.usuario = usuario;
            this.tipoAcesso = tipoAcesso;
            this.dtAcesso = DateTime.Now;
        }
        public override string ToString()
        {
            return "Data de acesso= " + this.dtAcesso.ToString("dd/MM/yyyy HH:mm:ss") + "\n" + usuario.ToString() + "\nTipo de acesso= " + this.tipoAcesso;
        }
    }
}
