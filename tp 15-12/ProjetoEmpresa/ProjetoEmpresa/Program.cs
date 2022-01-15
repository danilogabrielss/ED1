using Microsoft.SqlServer.Management.Common;
using System;
using Microsoft.Data.SqlClient;

namespace ProjetoEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conexao con = new Conexao();            
            //SqlCommand cmd = new SqlCommand();
            //con.conectar();
            /*string retornoConexao = "";
            try
            {
                //Conectar com o banco
                //cmd.Connection = con.conectar();
                cmd.Connection = con.disconectar();
                //executar comando
                //cmd.ExecuteNonQuery();
                //desconectando o banco                
                retornoConexao = "Entrou no SQL!";
                cmd.Connection = con.disconectar();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na conexao com o DB " + ex);
            }
            Console.WriteLine(retornoConexao);*/
            Ambiente ambiente = new Ambiente();
            Cadastro cadastro = new Cadastro();
            Usuario usuario = new Usuario();
            Log log = new Log();
            int fim = 0;
            do
            {
                Console.WriteLine("0. Sair\n1.Cadastrar ambiente\n2.Consultar ambiente\n3.Excluir ambiente\n4.Cadastrar usuario\n5.Consultar usuario\n6.Excluir usuario\n7.Conceder permissão de acesso ao usuario\n8.Revogar permissão de acesso ao usuario\n9.Registrar acesso\n10.Consultar logs de acesso");
                Console.Write("Digite uma das opcoes: ");
                int escolha = Convert.ToInt32(Console.ReadLine());
                switch (escolha)
                {
                    case 0: //Sair
                        fim = 10;
                        break;
                    case 1: //Cadastrar ambiente
                        Console.Write("Digite o id do ambiente: ");
                        int idAmbiente = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o nome do ambiente: ");
                        string nomeAmbiente = Console.ReadLine();
                        ambiente = new Ambiente(idAmbiente, nomeAmbiente);
                        cadastro.adicionarAmbiente(ambiente);
                        break;
                    case 2: //Consultar ambiente
                        Ambiente ambPesquisa = new Ambiente();
                        Console.Write("Digite o id do ambiente: ");
                        int idConsultaAmbiente = Convert.ToInt32(Console.ReadLine());
                        ambPesquisa = new Ambiente(idConsultaAmbiente, "");
                        Console.Write(cadastro.pesquisarAmbiente(ambPesquisa).ToString());
                        break;
                    case 3: //Excluir ambiente
                        Ambiente ambDeleta = new Ambiente();
                        Console.Write("Digite o id do ambiente: ");
                        int idDeletaAmbiente = Convert.ToInt32(Console.ReadLine());
                        ambDeleta = new Ambiente(idDeletaAmbiente, "");
                        Console.WriteLine(cadastro.removerAmbiente(ambDeleta));
                        break;
                    case 4: //Cadastrar usuario
                        Console.Write("Digite o id do usuario: ");
                        int idUsuario = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o nome do usuario: ");
                        string nomeUsuario = Console.ReadLine();
                        usuario = new Usuario(idUsuario, nomeUsuario);
                        cadastro.adicionarUsuario(usuario);
                        break;
                    case 5: //Consultar usuario
                        Usuario usuPesquisa = new Usuario();
                        Console.Write("Digite o id do usuario: ");
                        int idConsultaUsuario = Convert.ToInt32(Console.ReadLine());
                        usuPesquisa = new Usuario(idConsultaUsuario, "");
                        Console.WriteLine(cadastro.pesquisarUsuario(usuPesquisa).ToString());
                        break;
                    case 6: //Excluir usuario
                        Usuario usuDeleta = new Usuario();
                        Console.Write("Digite o id do usuario: ");
                        int idDeletaUsuario = Convert.ToInt32(Console.ReadLine());
                        usuDeleta = new Usuario(idDeletaUsuario, "");
                        Console.WriteLine(cadastro.removerUsuario(usuDeleta));
                        break;
                    case 7:  //Conceder permissão de acesso ao usuario
                        Console.Write("Digite o id do usuario a ser linkado: ");
                        int idSelecionaUsuario = Convert.ToInt32(Console.ReadLine());
                        foreach (Usuario usu in cadastro.usuarios)
                        {
                            if (usu.id == idSelecionaUsuario)
                            {
                                Console.Write("Digite o id do ambinete a ser linkado: ");
                                int idSelecionaAmbiente = Convert.ToInt32(Console.ReadLine());
                                foreach (Ambiente amb in cadastro.ambientes)
                                {
                                    if (amb.id == idSelecionaAmbiente)
                                    {
                                        Console.WriteLine(usuario.concederPermissao(ambiente));
                                    }
                                }
                            }
                        }
                        break;
                    case 8:  //Revogar permissão de acesso ao usuario
                        Console.Write("Digite o id do usuario a ser linkado: ");
                        int idSelecionaUsuarioRevoga = Convert.ToInt32(Console.ReadLine());
                        foreach (Usuario usu in cadastro.usuarios)
                        {
                            if (usu.id == idSelecionaUsuarioRevoga)
                            {
                                Console.Write("Digite o id do ambinete a ser linkado: ");
                                int idSelecionaAmbienteRevoga = Convert.ToInt32(Console.ReadLine());
                                foreach (Ambiente amb in cadastro.ambientes)
                                {
                                    if (amb.id == idSelecionaAmbienteRevoga)
                                    {
                                        Console.WriteLine(usuario.revogarPermissao(ambiente));
                                    }
                                }
                            }
                        }
                        break;
                    case 9:
                        Console.Write("Digite o id do ambinete: ");
                        int idAmb = Convert.ToInt32(Console.ReadLine());
                        bool retorno = false;
                        for (int j = 0; j < cadastro.ambientes.Count; j++)
                        {
                            if (ambiente.id == idAmb)
                            {
                                Console.Write("Digite o id do usuario: ");
                                int idUsu = Convert.ToInt32(Console.ReadLine());
                                for (int i = 0; i < cadastro.usuarios.Count; i++)
                                {
                                    if (usuario.id == idUsu)
                                    {
                                        foreach (Ambiente amb in usuario.ambientes)
                                        {
                                            if (amb.id == idAmb)
                                                retorno = true;
                                        }
                                        log = new Log(usuario, retorno);
                                        ambiente.registrarLog(log);
                                    }
                                }
                            }
                        }
                        break;
                    case 10:
                        Console.Write("Digite o id do ambinete: ");
                        int idAmbienteLog = Convert.ToInt32(Console.ReadLine());
                        for (int j = 0; j < cadastro.ambientes.Count; j++)
                        {
                            if (ambiente.id == idAmbienteLog)
                            {
                                for (int i = 0; i < ambiente.logs.Count; i++)
                                {
                                    Console.WriteLine(log.ToString());
                                }
                            }
                        }
                        break;
                }
            } while (fim != 10);
            cadastro.upload();
            //con.disconectar();
        }
    }
}
