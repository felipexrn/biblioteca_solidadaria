using System;
using Modelo;
using Negocio;
namespace Visao {
  class Biblioteca {
    public static void Main() {
      int option = Menu();
      LivroInserir();
      ExemplarInserir();

    }
    public static int Menu() {
      int op;
      Console.WriteLine(
        "00 = Sair do programa\n\n" +
        "---------------------\n" +
        "     Categorias\n\n" + 
        "---------------------\n" +
        "01 - Livros\n" +
        "02 - Exemplares\n" +
        "03 - Locação\n" +
        "04 - Locadores\n"
      );
      op = int.Parse(Console.ReadLine());
      switch(op) {
        case 1: op = 1; break;
        case 2: op = 2; break;
        case 3: op = 3; break;
        case 4: op = 4; break;
      }
      Console.WriteLine(
        "00 = Sair do programa\n\n" +
        "01 = Voltar para o menu anterior\n\n" +
        "---------------------\n" +
        "     Categorias\n\n" + 
        "---------------------\n" +
        "02 - Inserir livro\n" +
        "03 - Listar livros\n" +
        "04 - Atualizar livro\n" +
        "05 - Excluir livro\n"
      );
      return op;
    }
    public static void LivroInserir() {
      string t, v, e, a, d, i;
      Console.WriteLine("Digite o título do livro:");
      t = Console.ReadLine();
      Console.WriteLine("Digite o volume do livro");
      v = Console.ReadLine();
      Console.WriteLine("Digite a edição do livro");
      e = Console.ReadLine();
      Console.WriteLine("Digite o autor do livro");
      a = Console.ReadLine();
      Console.WriteLine("Digite a descrição do livro");
      d = Console.ReadLine();
      Console.WriteLine("Digite o ISBN do livro");
      i = Console.ReadLine();
      Livro l1 = new Livro {Titulo = t, Volume = v, Edicao = e, Autor = a, Descricao = d, Isbn = i};

      NLivro.LivroInserir(l1);

      Console.WriteLine("Livro inserido");
    }
    public static void LivroAtualizar() {}
    public static void LivroApagar() {}
    public static void LivroListar() {}
    public static void ExemplarInserir() {}
    public static void ExemplarAtualizar() {}
    public static void ExemplarApagar() {}
    public static void ExemplarListar() {}
    public static void LocacaoInserir() {}
    public static void LocacaoAtualizar() {}
    public static void LocacaoApagar() {}
    public static void LocacaoListar() {}
    public static void Devolucao() {}
    public static void LocadorInserir() {}
    public static void LocadorAtualizar() {}
    public static void LocadorApagar() {}
    public static void LocadorListar() {}
  }
}
