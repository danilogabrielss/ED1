using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEmpresa
{
    class Cadastro
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();

        public List<Usuario> usuarios { get; set; }
        public List<Ambiente> ambientes { get; set; }
        public Cadastro()
        {
            usuarios = new List<Usuario>();
            ambientes = new List<Ambiente>();
        }
        public void adicionarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }
        public bool removerUsuario(Usuario usuario)
        {
            foreach (Usuario usu in usuarios)
            {
                if (usu.id == usuario.id)
                {
                    if (usu.ambientes.Count == 0)
                    {
                        usuarios.Remove(usu);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Revoge permissoes para conseguir remover o usuario.");
                        return false;
                    }
                }
            }
            return false;
        }
        public Usuario pesquisarUsuario(Usuario usuario)
        {
            foreach (Usuario us in usuarios)
            {
                if (usuario.id == us.id)
                {
                    return us;
                }
            }
            return null;
        }
        public void adicionarAmbiente(Ambiente ambiente)
        {
            ambientes.Add(ambiente);
        }
        public bool removerAmbiente(Ambiente ambiente)
        {
            foreach (Ambiente amb in ambientes)
            {
                if (amb.id == ambiente.id)
                {
                    ambientes.Remove(amb);
                    return true;
                }
            }
            return false;
        }
        public Ambiente pesquisarAmbiente(Ambiente ambiente)
        {
            foreach (Ambiente amb in ambientes)
            {
                if (amb.id == ambiente.id)
                {
                    return amb;
                }
            }
            return null;
        }
        public void upload()
        {
            //string retornoConexao = "";
            string query = "";
            //Enviar Comando SQL
            //parametros
            //cmd.Parameters.AddWithValue("",);
            try
            {
                conn.Open();
                //cmd.Connection = con.conectar();
                foreach (Usuario u in usuarios)
                {
                    query = "INSERT INTO tb_usuario (cod_usuario, nome_usuario, cod_ambiente) " +
                        "VALUES ( @" + u.id + ", @" + u.nome + ", @" + u.ambientes + ")";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cod_usuario", u.id);
                    cmd.Parameters.AddWithValue("@nome_usuario", u.nome);
                    cmd.Parameters.AddWithValue("@cod_ambiente", u.ambientes);
                    cmd.ExecuteNonQuery();
                }
                /*foreach (Ambiente a in ambi
                 * entes)
                {
                    foreach (Log log in a.logs)
                    {
                        query = "INSERT INTO tb_log (cod_log, dt_dtacesso, cod_usuario, tipo_acesso) " +
                        "VALUES ( @" + ambientes.Count + ", @" + log.dtAcesso + ", @" + log.usuario.id + ", @" + log.tipoAcesso + ")";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@cod_log", a.logs);
                        cmd.Parameters.AddWithValue("@dt_dtacesso", log.dtAcesso);
                        cmd.Parameters.AddWithValue("@cod_usuario", log.usuario.id);
                        cmd.Parameters.AddWithValue("@tipo_acesso", log.tipoAcesso);
                        cmd.ExecuteNonQuery();
                    }
                    query = "INSERT INTO tb_ambiente (cod_ambiente, nome_ambiente, cod_log) " +
                    "VALUES (@" + a.id + ", @" + a.nome + ", @" + a.logs + ")";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cod_ambiente", a.id);
                    cmd.Parameters.AddWithValue("@nome_ambiente", a.nome);
                    cmd.Parameters.AddWithValue("@cod_log", a.logs);
                    cmd.ExecuteNonQuery();
                }*/
                
            }
            catch (SqlException ex)
            {
                //retornoConexao = "Erro ao tentar conectar com o SQL Server";
            }
            conn.Close();
        }
        public void download()
        {
            /*foreach (Usuario u in usuarios)
            {
                query = "INSERT INTO tb_usuario (cod_usuario, nome_usuario) VALUES (" + u.Id + ", " + u.Nome + ")";
                comando.CommandText = query;
            }
            foreach (Ambiente a in ambientes)
            {
                query = "INSERT INTO tb_ambiente (cod_ambiente, nome_ambiente) VALUES (" + a.Id + ", " + a.Nome + ")";
                comando.CommandText = query;
            }
            */
        }
    }
}
