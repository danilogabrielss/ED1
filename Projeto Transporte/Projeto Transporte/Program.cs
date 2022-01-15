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
                Console.WriteLine("1. Cadastrar veículo\n2.Cadastrar garagem\n3.Iniciar jornada\n4.Encerrar jornada\n5.Liberar viagem de uma determinada origem para um determinado destino\n6.Listar veículos em determinada garagem(informando a qtde de veículos e seu potencial de transporte)\n7.Informar qtde de viagens efetuadas de uma determinada origem para um determinado destino\n8.Listar viagens efetuadas de uma determinada origem para um determinado destino\n9.Informar qtde de passageiros transportados de uma determinada origem para um determinado destino\n9. Sair");
                Console.Write("Digite a opcao: ");
                int escolha = Convert.ToInt32(Console.ReadLine());
                switch (escolha)
                {
                    case 1: //Cadastrar veiculo
                        Console.Write("Digite o ID do veiculo: ");
                        int idVeiculo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o placa do veiculo: ");
                        string placaVeiculo = Console.ReadLine();
                        Console.Write("Digite o placa do veiculo: ");
                        int lotacao = Convert.ToInt32(Console.ReadLine());
                        veiculo = new Veiculo(idVeiculo, placaVeiculo, lotacao);
                        veiculos.incluir(veiculo);
                        break;
                    case 2: // cadastrar garagem
                        Console.Write("Digite o ID da garagem: ");
                        int idGaragem = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nDigite o local da garagem: ");
                        string local = Console.ReadLine();
                        garagem = new Garagem(idGaragem, local);
                        garagens.incluir(garagem);
                        break;
                    case 3: //iniciar jornada
                        garagens.iniciarJornada();
                        break;
                    case 4: //encerrar jornada
                        //garagens.encerrarJornada();
                        break;
                    case 5: //Liberar viagem de uma determinada origem para um determinado destino
                        //origem destino e veiculo
                        Console.Write("Digite o origem da viagem(id da garagem): ");
                        int idLiberaViagem = Convert.ToInt32(Console.ReadLine());

                        break;
                    case 6: //Listar veículos em determinada garagem
                        Console.Write("Digite o id da garagem: ");
                        int idListaGaragem = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < garagens.garagens.Count; i++)
                        {
                            if (garagem.id == idListaGaragem)
                            {
                                foreach (Veiculo v1 in garagem.veiculos) v1.ToString();
                            }
                        }
                        break;
                    case 7: //Informar qtde de viagens efetuadas de uma determinada origem para um determinado destino 


                        break;
                }
            } while (fim == 10);
        }
    }

}
