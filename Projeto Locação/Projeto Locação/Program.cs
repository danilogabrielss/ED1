using System;

namespace Projeto_Locação
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipamento equipamento = new Equipamento();
            Contrato contrato = new Contrato();
            Contratos contratos = new Contratos();
            Estoque estoque = new Estoque();
            int fim = 0;
            do
            {
                Console.WriteLine("1. Cadastrar tipo de equipamento\n2. Consultar tipo de equipamento\n3. Cadastrar equipamento (item em um determinado tipo)\n4. Registrar Contrato de Locação\n5. Consultar Contratos de Locação (com os respectivos itens contratados)\n6. Liberar de Contrato de Locação\n7. Consultar Contratos de Locação liberados (com os respectivos itens)\n8. Devolver equipamentos de Contrato de Locação liberado\n9. Sair");
                Console.Write("Digite a opcao: ");
                int escolha = Convert.ToInt32(Console.ReadLine());
                switch (escolha)
                {
                    case 1: //Cadastrar tipo de equipamento 
                        Console.Write("Digite o id do tipo do equipamento: ");
                        int idEq = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite nome do tipo do equipamento: ");
                        string nomeTipoEquip = Console.ReadLine();
                        estoque = new Estoque(idEq, nomeTipoEquip);
                        contrato.adicionarTipoEquipamento(estoque);
                        break;
                    case 2: //Consultar tipo de equipamento (com os respectivos itens cadastrados) 
                        Console.Write("Digite o id do tipo do equipamento: ");
                        int idEqPesq = Convert.ToInt32(Console.ReadLine());
                        Estoque estoquePesq = new Estoque(idEqPesq, "");
                        Console.WriteLine(contrato.pesquisarTipoEquipamento(estoquePesq));
                        break;
                    case 3: //3. Cadastrar equipamento (item em um determinado tipo) 
                        Console.Write("Digite o id do tipo do equipamento: ");
                        int idEq3 = Convert.ToInt32(Console.ReadLine());
                        foreach (Estoque e in contrato.estoques)
                        {
                            if (e.id == idEq3)
                            {
                                Console.Write("Digite se o equipamento esta danificado:(true//false) ");
                                bool avariado = Convert.ToBoolean(Console.ReadLine());
                                Console.Write("Digite a taxa diaria do equipamento: ");
                                float taxaDia = Convert.ToInt32(Console.ReadLine());
                                equipamento = new Equipamento(avariado, taxaDia);
                                e.devolverEquipamento(equipamento);
                            }
                        }
                        break;
                    case 4: //4.Registrar Contrato de Locação
                        Console.Write("Digite o id do contrato: ");
                        int idContrato = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o id do tipo do equipamento: ");
                        int idEq4 = Convert.ToInt32(Console.ReadLine());
                        foreach (Estoque e in contrato.estoques)
                        {
                            if (e.id == idEq4)
                            {
                                Console.Write("Digite a quantidade de equipamento solicitada: ");
                                int qtde = Convert.ToInt32(Console.ReadLine());
                                if (e.equipamentos.Count >= qtde)
                                {
                                    contrato = new Contrato(idContrato, qtde);
                                    contratos.adicionarContrato(contrato);
                                }
                                else
                                {
                                    Console.WriteLine("Contrato recusado pois não tem equipamento suficiente no estoque");
                                }
                            }
                        }
                        break;
                    case 5: //5. Consultar Contratos de Locação (com os respectivos itens contratados) 
                        Console.Write("Digite o id do contrato: ");
                        int idContratoPesq = Convert.ToInt32(Console.ReadLine());
                        Contrato contratoPesq = new Contrato(idContratoPesq, 0);
                        Console.WriteLine(contratos.pesquisarContrato(contratoPesq).ToString());
                        break;
                    case 6: //6. Liberar de Contrato de Locação 
                        Console.Write("Digite o id do contrato a ser liberado: ");
                        int idContratoLibera = Convert.ToInt32(Console.ReadLine());
                        foreach (Contrato c in contratos.contratos)
                        {
                            if (c.id == idContratoLibera)
                            {
                                c.liberarContrato(estoque);
                            }
                        }
                        break;
                    case 7: //Consultar Contratos de Locação liberados (com os respectivos itens) 
                        if (contrato.dataSaida.Year != 4000)
                        {
                            Console.WriteLine(contratos.listarContato(contrato));
                        }
                        break;
                    case 8: //Devolver equipamentos de Contrato de Locação liberado 
                        Console.Write("Digite o id do contrato a ser liberado: ");
                        int idContratoDevolve = Convert.ToInt32(Console.ReadLine());
                        foreach (Contrato c in contratos.contratos)
                        {
                            if (c.id == idContratoDevolve)
                            {
                                c.devolverEquipamentos(estoque,equipamento);
                            }
                        }
                        break;
                    case 9:
                        fim = 10;
                        break;
                }
            } while (fim != 10);

        }
    }
}