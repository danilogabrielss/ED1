using System;

namespace Projeto_Medicamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Lote lote = new Lote();
            Medicamento medicamento = new Medicamento();
            Medicamentos medicamentos = new Medicamentos();
            int fim = 0;
            do
            {
                Console.WriteLine("0.Finalizar processo\n1.Cadastrar medicamento\n2.Consultar medicamento(sintético)\n3.Consultar medicamento(analítico)\n4.Comprar medicamento\n5.Vender medicamento\n6.Listar medicamentos");
                Console.Write("Digite uma das opcoes: ");
                int escolha = Convert.ToInt32(Console.ReadLine());
                switch (escolha)
                {
                    case 0:
                        fim = 10;
                        break;
                    case 1:
                        Console.Write("Digite o id do medicamento: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o nome do medicamento: ");
                        string nomeMed = Console.ReadLine();
                        Console.Write("Digite o laboratorio do medicamento: ");
                        string lab = Console.ReadLine();
                        medicamentos.adicionar(new Medicamento(id, nomeMed, lab));
                        break;
                    case 2: //pesquisa simples
                        Medicamento pesq = new Medicamento();
                        Console.Write("Digite o id a ser pesquisado: ");
                        pesq.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(medicamentos.pesquisar(pesq).toString());
                        break;
                    case 3: //pesquisa com lotes
                        Medicamento pesq1 = new Medicamento();
                        Console.Write("Digite o id a ser pesquisado: ");
                        int idPesq1 = Convert.ToInt32(Console.ReadLine());
                        pesq1.id = idPesq1;
                        Console.WriteLine(medicamentos.pesquisar(pesq1).tooString());
                        break;
                    case 4: //Cadastra lote                        
                        Console.Write("Digite a quantidade de remedios a ser comprados: ");
                        int compra = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite a validade(dd/MM/yyyy) : ");
                        DateTime data = Convert.ToDateTime(Console.ReadLine());
                        lote = new Lote(compra, data);
                        Console.Write("Digite o id do medicamento: ");
                        int idCadastro = Convert.ToInt32(Console.ReadLine());
                        medicamento = new Medicamento(idCadastro, "", "");
                        foreach (Medicamento med in medicamentos.listaMedicamentos)
                        {
                            if (med.Equals(medicamento))
                            {                               
                                medicamento.comprar(lote);
                                Console.WriteLine("Medicamento comprado.");
                            }
                            else
                            {
                                Console.WriteLine("ID inexistente.");
                            }
                        }
                        break;
                    case 5: //Vender medicamento
                        Console.Write("Digite a quantidade de remedios a ser vendidos: ");
                        int venda = Convert.ToInt32(Console.ReadLine());
                        medicamento.vender(venda);
                        break;
                    case 6: //Listar medicamentos
                        foreach (Medicamento m in medicamentos.listaMedicamentos)
                        {
                            Console.WriteLine(m.toString());
                        }
                        break;
                    default:
                        Console.WriteLine("Numero errado.");
                        break;
                }

            } while (fim != 10);
        }
    }
}
