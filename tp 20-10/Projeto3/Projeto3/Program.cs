using System;

namespace Projeto3
{
    class Program
    {
        static void Main(string[] args)
        {
            double escolha, fim = 0;
            Data data = new Data();
            Contato contato = new Contato();
            Contatos contatos = new Contatos();
            do
            {
                Console.WriteLine("-----------------------\n| 0.Sair              |\n| 1.Adicionar contato |\n| 2.Pesquisar contato |\n| 3.Alterar contato   |\n| 4.Remover contato   |\n| 5.Listar contatos   |\n-----------------------\n");
                Console.Write("Digite uma das opcoes: ");
                escolha = Convert.ToDouble(Console.ReadLine());

                switch (escolha)
                {
                    case 0:
                        fim = 10;
                        break;
                    case 1:
                        Console.Write("Digite o email: ");
                        string email = Console.ReadLine();
                        Console.Write("Digite o nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite o telefone: ");
                        string telefone = Console.ReadLine();
                        Console.Write("Digite o dia: ");
                        int dia = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o mes: ");
                        int mes = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o ano: ");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        data = new Data(dia, mes, ano);
                        contato = new Contato(email, nome, telefone, data);
                        Console.WriteLine(contatos.adicionar(contato));
                        break;
                    case 2:
                        Contato pesquisar = new Contato();
                        Console.Write("Digite o email a ser pesquisado: ");
                        string emailPesquisar = Console.ReadLine();
                        pesquisar.email = emailPesquisar;
                        Console.WriteLine(contatos.pesquisar(pesquisar).ToString());
                        break;
                    case 3:
                        Console.WriteLine(contatos.alterar(contato));
                        break;
                    case 4:
                        Console.WriteLine(contatos.remover(contato));
                        break;
                    case 5:
                        foreach (Contato ctt in contatos.agenda)
                        {
                            Console.WriteLine(ctt.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("O numero digitado é invalido.");
                        break;
                }
            } while (fim != 10);
            Console.WriteLine(contato.ToString());
        }
    }
}

