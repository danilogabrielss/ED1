using System;

namespace Projeto4
{
    class Program
    {
        static void Main(string[] args)
        {
            double escolha, fim = 0;
            Livros livros = new Livros();
            Livro livro = new Livro();
            Exemplar exemplar = new Exemplar();
            Emprestimo emprestimo = new Emprestimo();
            do
            {
                Console.WriteLine("-------------------------------\n| 0.Sair                      |\n| 1.Adicionar livro           |\n| 2.Pesquisar livro(sintético)|\n| 3.Pesquisar livro(analítico)|\n| 4.Adicionar exemplar        |\n| 5.Registrar empréstimo      |\n| 6.Registrar devolução       |\n-------------------------------");
                Console.Write("Digite uma das opcoes: ");
                escolha = Convert.ToDouble(Console.ReadLine());

                switch (escolha)
                {
                    case 0:
                        fim = 10;
                        break;
                    case 1://Adicionar
                        Console.Write("Digite o ISBN do livro: ");
                        int isbn = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o titulo do livro: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Digite o autor do livro: ");
                        string autor = Console.ReadLine();
                        Console.Write("Digite o editora do livro: ");
                        string editora = Console.ReadLine();
                        livros.adicionar(livro = new Livro(isbn, titulo, autor, editora));
                        //exemplar = new Exemplar(15);
                        //livro.adicionarExemplar(exemplar);
                        break;
                    case 2://Pesquisar
                        Livro pesquisar = new Livro();
                        Console.Write("Digite o ISBN do livro a ser pesquisado: ");
                        int isbnPesquisar = Convert.ToInt32(Console.ReadLine());
                        pesquisar.isbn = isbnPesquisar;
                        Console.WriteLine(livros.pesquisar(pesquisar).TooString());
                        break;
                    case 3://Pesquisar
                        Livro pesquisaAnalitica = new Livro();
                        Console.Write("Digite o ISBN do livro a ser pesquisado: ");
                        int isbnPesquisa = Convert.ToInt32(Console.ReadLine());
                        pesquisaAnalitica.isbn = isbnPesquisa;
                        Console.WriteLine(livros.pesquisar(pesquisaAnalitica).toString());
                        break;
                    case 4://Adicionar exemplar
                        Console.Write("Digite o isbn do livro: ");
                        int isbnLivroExemplar = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < livros.acervo.Count; i++)
                        {
                            if (livro.isbn == isbnLivroExemplar)
                            {
                                Console.Write("Digite o Tombo do livro: ");
                                int tombo = Convert.ToInt32(Console.ReadLine());
                                exemplar = new Exemplar(tombo);
                                livro.adicionarExemplar(exemplar);
                            }
                            else
                            {
                                Console.WriteLine("Livro nao encontrado.");
                            }
                        }
                        break;
                    case 5://Registrar empréstimo
                        Console.Write("Digite o isbn do livro: ");
                        int isbnLivro = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o tombo do livro: ");
                        int tomboPesq = Convert.ToInt32(Console.ReadLine());
                        foreach (Livro li in livros.acervo)
                        {
                            if (li.isbn == isbnLivro)
                            {
                                foreach (Exemplar ex in livro.exemplares)
                                    if (ex.tombo == tomboPesq)
                                        exemplar.emprestar();
                            }
                            else
                            {
                                Console.WriteLine("Livro nao encontrado.");
                            }
                        }
                        break;
                    case 6://Registrar devolucao
                        Console.Write("Digite o isbn do livro: ");
                        int pesq = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o tombo do livro: ");
                        int tomboPesqDevolve = Convert.ToInt32(Console.ReadLine());
                        foreach (Livro li in livros.acervo)
                        {
                            if (li.isbn == pesq)
                            {
                                foreach (Exemplar ex in livro.exemplares)
                                    if (ex.tombo == tomboPesqDevolve)
                                        exemplar.devolver();
                            }
                            else
                            {
                                Console.WriteLine("Livro nao encontrado.");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("O numero digitado esta errado");
                        break;
                }
            } while (fim != 10);
        }
    }
}
