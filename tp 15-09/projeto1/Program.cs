using System;

namespace projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            double escolha, fim = 0;
            int i = 0;
            Venda[] venda = new Venda[31];
            for (int x = 0; x < 31; ++x)
                venda[x] = new Venda();
            Vendedor[] vendedor = new Vendedor[10];
            for (int y = 0; y < 10; ++y)
                vendedor[y] = new Vendedor();
            Vendedores[] vendedores = new Vendedores[10];
            for (int z = 0; z < 10; ++z)
                vendedores[z] = new Vendedores();

            //string contiunuar = "S";
            do //(contiunuar == "S")
            {
                Console.WriteLine("0.Sair \n1.Cadastrar vendedor \n2.Consultar vendedor \n3.Excluir vendedor \n4.Registrar venda \n5.Listar vendedores");
                Console.Write("Digite uma das opcoes: ");
                escolha = Convert.ToDouble(Console.ReadLine());

                switch (escolha)
                {
                    case 0:
                        fim = 10;
                        break;
                    case 1:
                        Console.WriteLine("Id: " + i);
                        Console.Write("Qual o nome do vendedor? ");
                        string nome = Console.ReadLine();
                        Console.Write("Qual a porcentagem de comissão do vendedor? ");
                        double perc = Convert.ToDouble(Console.ReadLine());
                        vendedor[i] = new Vendedor(i, nome, perc, venda);
                        vendedores[i] = new Vendedores(i, vendedor);
                        Console.WriteLine(vendedores[i].addVendedor(vendedor[i]));
                        ++i;
                        break;
                    case 2:
                        {
                            Console.Write("Digite o ID do vendedor que deseja consultar: ");
                            int idConsult = Convert.ToInt32(Console.ReadLine());
                            Vendedor encontrar = new Vendedor();
                            encontrar.Nome = vendedor[idConsult].Nome; ;
                            if (encontrar.Nome != "")
                            {
                                Console.WriteLine("\nID: " + vendedor[idConsult].Id);
                                Console.WriteLine("Nome: " + vendedor[idConsult].Nome);
                                Console.WriteLine("Valor de vendas: " + vendedor[idConsult].valorVendas());
                                Console.WriteLine("Comissão: " + vendedor[idConsult].valorComissao());
                                Console.WriteLine("Valor médio das vendas diários: " + venda[idConsult].valorMedio());
                            }
                            else
                            {
                                Console.WriteLine("Vendedor não encontrado");
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Digite o ID do vendedor que deseja excluir: ");
                            int idDel = Convert.ToInt32(Console.ReadLine());
                            while (idDel > 10 || idDel < 0)
                            {
                                Console.WriteLine("Numero incorreto");
                                Console.Write("Digite o ID do vendedor que deseja excluir: ");
                                idDel = Convert.ToInt32(Console.ReadLine());
                            }
                            Vendedor[] consultar = new Vendedor[10];
                            if (vendedor[idDel].Nome != "")
                            {
                                Console.WriteLine(vendedores[idDel].delVendedor(vendedor[idDel]));
                            }
                            else
                            {
                                Console.WriteLine("Id inexistente");
                            }
                        }
                        break;
                    case 4:
                        Console.Write("Digite o ID do vendedor a ser usado: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        while (id > 10 || id < 0)
                        {
                            Console.WriteLine("Numero incorreto");
                            Console.Write("Digite o ID do vendedor a ser usado: ");
                            id = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("Digite o dia da Venda: ");
                        int diaVenda = Convert.ToInt32(Console.ReadLine());
                        while (diaVenda > 31 || diaVenda < 0)
                        {
                            Console.WriteLine("Dia incorreto");
                            Console.Write("Digite o dia da Venda: ");
                            diaVenda = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("Digite a quantidade de vendas no dia: ");
                        venda[id].Qtde = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o valor da venda: ");
                        venda[id].Valor = Convert.ToDouble(Console.ReadLine());
                        vendedor[id].registrarVenda(diaVenda, venda[id]);
                        break;
                    case 5:
                        for (int list =0;list <10; list++)
                        {
                            if (vendedor[list].Nome != "")
                            {
                                Console.WriteLine("Id: "+ vendedor[list].Id);
                                Console.WriteLine("Nome: " + vendedor[list].Nome);
                                Console.WriteLine("Valor de vendas: " + vendedor[list].valorVendas());
                                Console.WriteLine("Valor de comissões: " + vendedor[list].valorComissao());
                                double totalVenda = vendedor[list].valorVendas() + vendedor[list].valorComissao();
                                Console.WriteLine("Valor total em vendas : "+ totalVenda);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Numero Inserido esta errado");
                        break;
                }
                //Console.Clear();
            } while (fim != 10);
        }
    }
}
