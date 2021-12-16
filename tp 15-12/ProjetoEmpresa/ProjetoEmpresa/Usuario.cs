using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEmpresa
{
    class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public List<Ambiente> ambientes { get; set; }
        public Usuario()
        {
            this.ambientes = new List<Ambiente>();
        }
        public Usuario(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
            this.ambientes = new List<Ambiente>();
        }
        public bool concederPermissao(Ambiente ambiente)
        {
            if(ambientes.Count == 0)
            {
                ambientes.Add(ambiente);
                return true;
            }
            foreach (Ambiente amb in ambientes)
            {
                if (amb.id != ambiente.id)
                {
                    ambientes.Add(ambiente);
                    return true;
                }
            }
            return false;
        }
        public bool revogarPermissao(Ambiente ambiente)
        {
            foreach (Ambiente amb in ambientes)
            {
                if (amb.id == ambiente.id)
                {
                    ambientes.Remove(ambiente);
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            string permissaoRetorno = "";
            foreach (Ambiente amb in ambientes)
            {
                permissaoRetorno += amb.ToString();
            }
            return "Usuario id=" + this.id + "\nNome= " + this.nome + "\nPermissao de ambiente:" + permissaoRetorno;
        }
    }
}
