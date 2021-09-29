using System;

namespace projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha, fim = 0;
            Participante[] participante = new Participante[900];
            Evento[] evento = new Evento[7];
            Eventos[] eventos = new Eventos[7];
            for (int x = 0; x < 900; ++x)
                participante[x] = new Participante();
            for (int y = 0; y < 7; ++y)
                evento[y] = new Evento();
            for (int z = 0; z < 7; ++z)
                eventos[z] = new Eventos();
            do
            {
                //Console.Clear();
                Console.WriteLine("0. Sair\n" +
                    "1.Adicionar evento(escolher o dia, onde 1 = SEG, 2 = TER, ..., 6 = SAB)\n" +
                    "2.Pesquisar evento\n" + "3.Listar eventos\n" + "4.Adicionar participante\n" +
                    "5.Pesquisar participante\n" +
                    "6.Informar quantidade total de participantes nos eventos da semana");
                Console.Write("Digite uma das opcoes: ");
                escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 0:
                        fim = 10;
                        break;
                    case 1:
                        Console.Write("\nDigite o dia da semana em numero(1=SEG a 6=SAB): ");
                        int dia = Convert.ToInt32(Console.ReadLine());
                        while (dia > 7 || dia < 0)
                        {
                            Console.Write("Digite o dia da semana em numero(1=SEG a 6=SAB): ");
                            dia = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("Digite a descricao do evento: ");
                        string desc = Console.ReadLine();
                        Console.Write("Digite a quantidade maxima de pessoas no evento: ");
                        int qtd = Convert.ToInt32(Console.ReadLine());
                        eventos[dia] = new Eventos(evento);
                        evento[dia] = new Evento(dia, desc, qtd, participante);
                        Console.WriteLine(eventos[dia].adicionarEvento(evento[dia]));
                        break;
                    case 2:
                        Console.Write("\nQual dia do evento voce deseja pesquisar(1=SEG a 6=SAB)? ");
                        int diaPesquisa = Convert.ToInt32(Console.ReadLine());
                        while (diaPesquisa > 6 || diaPesquisa < 1)
                        {
                            Console.Write("Qual dia do evento voce deseja pesquisar(1=SEG a 6=SAB)? ");
                            diaPesquisa = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine(evento[diaPesquisa].toString() + "\n" +
                        evento[diaPesquisa].listaParticipantes());
                        Console.WriteLine();
                        break;
                    case 3:
                        for (int a = 0; a < 7; ++a)
                        {
                            if (evento[a].Descricao != "")
                            {
                                Console.WriteLine("\nDia da semana: " + evento[a].Id);
                                Console.WriteLine("Descricao: " + evento[a].Descricao);
                                Console.WriteLine("Quantidade atual de participantes: " + evento[a].qtdeParticipantes());
                                Console.WriteLine("Quantidade maxima de participantes: " + evento[a].QtdeMaxParticipantes);
                            }
                        }
                        break;
                    case 4:
                        Console.Write("\nDigite o nome do participante: ");
                        string nomeParticipante = Console.ReadLine();
                        Console.Write("Digite o email do participante: ");
                        string emailParticipante = Console.ReadLine();
                        Console.Write("Digite o dia do evento: ");
                        int diaEvento = Convert.ToInt32(Console.ReadLine());
                        while (diaEvento > 7 || diaEvento < 0)
                        {
                            Console.WriteLine("Digite o dia do evento: ");
                            diaEvento = Convert.ToInt32(Console.ReadLine());
                        }
                        participante[diaEvento] = new Participante(emailParticipante, nomeParticipante);
                        Console.WriteLine(evento[diaEvento].inscreverParticipante(participante[diaEvento]));
                        break;
                    case 5:
                        Console.Write("\nDigite o email da pessoa a ser procurada: ");
                        string search = Console.ReadLine();
                        Console.Write("\nDigite o dia do evento: ");
                        int diaPesqEvento = Convert.ToInt32(Console.ReadLine());
                        while (diaPesqEvento > 7 || diaPesqEvento < 0)
                        {
                            Console.WriteLine("Digite o dia do evento: ");
                            diaPesqEvento = Convert.ToInt32(Console.ReadLine());
                        }                        
                        Participante[] encontrar = new Participante[6];
                        encontrar[diaPesqEvento] = new Participante(search, "");
                        Console.WriteLine(eventos[diaPesqEvento].pesquisarParticipante(encontrar[diaPesqEvento]));
                        break;
                    case 6:
                        int total = 0;
                        for (int i = 0; i < 7; ++i)
                        {
                            total += evento[i].qtdeParticipantes();
                        }
                        Console.WriteLine("Total de participantes é " + total);
                        break;
                    default:
                        Console.WriteLine("O numero inserido é invalido");
                        break;
                }
            } while (fim != 10);
        }
    }
}


