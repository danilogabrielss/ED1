using System;

namespace Projeto_Transporte
{
    class Program
    {
        static void Main(string[] args)
        {
            Garagem garagem = new Garagem();
            Garagens garagens = new Garagens();
            Veiculo veiculo = new Veiculo();
            Veiculos veiculos = new Veiculos();
            Viagem viagem = new Viagem();
            Viagens viagens = new Viagens();
            Transporte transporte = new Transporte();
            int fim = 0;
            do
            {
                Console.WriteLine("1.Cadastrar veículo\n2.Cadastrar garagem\n3.Iniciar jornada\n4.Encerrar jornada\n5.Liberar viagem de uma determinada origem para um determinado destino\n6.Listar veículos em determinada garagem(informando a qtde de veículos e seu potencial de transporte)\n7.Informar qtde de viagens efetuadas de uma determinada origem para um determinado destino\n8.Listar viagens efetuadas de uma determinada origem para um determinado destino\n9.Informar qtde de passageiros transportados de uma determinada origem para um determinado destino\n10. Sair");
                Console.Write("Digite a opcao: ");
                int escolha = Convert.ToInt32(Console.ReadLine());
                switch (escolha)
                {
                    case 1: //Cadastrar veiculo
                        Console.Write("Digite o ID do veiculo: ");
                        int idVeiculo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o placa do veiculo: ");
                        string placaVeiculo = Console.ReadLine();
                        Console.Write("Digite a lotacao do veiculo: ");
                        int lotacao = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o ID da garagem: ");
                        int idGaragemAdd = Convert.ToInt32(Console.ReadLine());
                        foreach (Garagem g in garagens.garagens)
                        {
                            if (idGaragemAdd == g.id)
                            {
                                veiculo = new Veiculo(idVeiculo, placaVeiculo, lotacao);
                                veiculos.incluir(veiculo);
                                g.Veiculos.Push(veiculo);
                                Console.WriteLine("Veículo registrado na garagem");
                            }
                        }
                        break;
                    case 2: // cadastrar garagem
                        Console.Write("Digite o ID da garagem: ");
                        int idGaragem = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o local da garagem: ");
                        string local = Console.ReadLine();
                        garagem = new Garagem(idGaragem, local);
                        garagens.incluir(garagem);
                        break;
                    case 3: //iniciar jornada
                        if (garagens.jornadaAtiva != true)
                        {
                            garagens.iniciarJornada();
                            Console.WriteLine("Jornada iniciada");
                        }
                        else
                            Console.WriteLine("Jornada em andamento");
                        break;
                    case 4: //encerrar jornada
                        garagens.encerrarJornada();
                        break;
                    case 5: //Liberar viagem de uma determinada origem para um determinado destino
                        //origem destino e veiculo
                        Console.Write("Digite o id da origem da garagem: ");
                        int idOrigem = Convert.ToInt32(Console.ReadLine());
                        foreach (Garagem g in garagens.garagens)
                        {
                            if (g.id == idOrigem)
                            {
                                Console.Write("Digite o id do destino da garagem: ");
                                int idDestino = Convert.ToInt32(Console.ReadLine());
                                foreach (Garagem ga in garagens.garagens)
                                {
                                    if (ga.id == idDestino)
                                    {
                                        Console.Write("Digite o id do veiculo que ira fazer a viagem: ");
                                        int idVeiculoViagem = Convert.ToInt32(Console.ReadLine());
                                        foreach (Veiculo v in g.Veiculos)
                                        {
                                            if (idVeiculoViagem == v.id)
                                            {
                                                garagens.transportes.Add(new Transporte(v, v.lotacao));
                                                viagem = new Viagem(g, ga, v);
                                                viagens.incluir(viagem);
                                                g.Veiculos.Pop();
                                                ga.Veiculos.Push(v);
                                                Console.WriteLine("Viagem Inclusa.");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 6: //Listar veículos em determinada garagem
                        Console.Write("Digite o id da garagem: ");
                        int idListaGaragem = Convert.ToInt32(Console.ReadLine());
                        foreach (Garagem g in garagens.garagens)
                        {
                            if (g.id == idListaGaragem)
                            {
                                foreach (Veiculo v1 in garagem.Veiculos)
                                {
                                    Console.WriteLine(v1.ToString());
                                }
                            }
                        }
                        break;
                    case 7: //Informar qtde de viagens efetuadas de uma determinada origem para um determinado destino 
                        int qtdeRet = 0;
                        Console.Write("Digite o id da origem da garagem: ");
                        int idOri = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o id do destino da garagem: ");
                        int idDest = Convert.ToInt32(Console.ReadLine());
                        foreach (Viagem vi in viagens.Viagenss)
                        {
                            if (vi.origem.Equals(garagens.pesquisarGaragem(new Garagem(idOri, ""))) && vi.destino.Equals(garagens.pesquisarGaragem(new Garagem(idDest, ""))))
                            {
                                qtdeRet++;
                            }
                        }
                        Console.WriteLine("Total de viagem é " + qtdeRet);
                        break;
                    case 8: //Listar viagens efetuadas de uma determinada origem para um determinado destino 
                        Console.Write("Digite o id da origem da garagem: ");
                        idOri = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o id do destino da garagem: ");
                        idDest = Convert.ToInt32(Console.ReadLine());
                        foreach (Viagem vi in viagens.Viagenss)
                        {
                            if (vi.origem.Equals(garagens.pesquisarGaragem(new Garagem(idOri, ""))) && vi.destino.Equals(garagens.pesquisarGaragem(new Garagem(idDest, ""))))
                            {
                                Console.WriteLine(vi.ToString());
                            }
                        }
                        break;
                    case 9:
                        Console.Write("Digite o id da origem da garagem: ");
                        idOri = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o id do destino da garagem: ");
                        idDest = Convert.ToInt32(Console.ReadLine());
                        int qtdePassageiros = 0;
                        foreach (Viagem vi in viagens.Viagenss)
                        {
                            if (vi.origem.Equals(garagens.pesquisarGaragem(new Garagem(idOri, ""))) && vi.destino.Equals(garagens.pesquisarGaragem(new Garagem(idDest, ""))))
                            {
                                qtdePassageiros += vi.veiculo.lotacao;
                            }
                        }
                        Console.WriteLine("Quantidade de passageiros transportado foi " + qtdePassageiros);
                        break;
                    case 10:
                        fim = 10;
                        break;
                }
            } while (fim != 10);
        }
    }

}
