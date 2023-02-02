using System;
using Modelo;
using Negocio;
namespace Visao {
  class Biblioteca {
    public static void Main() {
      int op = Menu();
      while(op!=0) {
        try {
          switch(op) {
            case 1: LivroInserir(); break; // Implementado
            case 2: LivroListar(); break;  // Implementado
            case 3: LivroAtualizar(); break;  // Implementado
            case 4: LivroApagar(); break;  // Implementado
            case 5: ExemplarInserir(); break;
            case 6: ExemplarListar(); break;
            case 7: ExemplarAtualizar(); break;
            case 8: ExemplarApagar(); break;
            case 9: LocacaoInserir(); break;
            case 10: LocacaoListar(); break;
            case 11: LocacaoAtualizar(); break;
            case 12: LocacaoApagar(); break;
            case 13: LocadorInserir(); break;
            case 14: LocadorListar(); break;
            case 15: LocadorAtualizar(); break;
            case 16: LocadorApagar(); break;
            case 17: Devolucao(); break;
          }
        }
        catch (Exception erro) {
          Console.WriteLine(erro.Message + "\n");
        }
        op = Menu();
      }
      Console.Clear();
      Console.WriteLine("Programa encerrado");
    }
    public static int Menu() {
      int op;
      Console.WriteLine(
        "00 = Sair do programa\n" +
        "---------------------\n" +
        "     Categorias\n" + 
        "---------------------\n" +
        "01 = Livros\n" +
        "02 = Exemplares\n" +
        "03 = Locação\n" +
        "04 = Locadores\n" + 
        "05 = Devolução"
      );
      op = int.Parse(Console.ReadLine());
      if (op > 4 || op < 0 && op != 17) {
        Console.Clear();
        Console.WriteLine("Valor escolhido é inválido\n");
        op = Menu();
      }
      Console.Clear();
      if (op == 0) return op;
      if (op == 1) {
        Console.WriteLine(
        "00 = Sair do programa\n" +
        "01 = Voltar para o menu anterior\n" +
        "---------------------\n" +
        "  Categoria  Livros\n" + 
        "---------------------\n" +
        "02 - Inserir livro\n" +
        "03 - Listar livros\n" +
        "04 - Atualizar livro\n" +
        "05 - Excluir livro"
        );
        op = int.Parse(Console.ReadLine());
        if (op == 0) return 0;
        if (op == 1) {
          Console.Clear();
          op = Menu();
        }
        switch(op) {
        case 2: return 1;
        case 3: return 2;
        case 4: return 3;
        case 5: return 4;
        }
      }
      if (op == 2) {
        Console.WriteLine(
        "00 = Sair do programa\n" +
        "01 = Voltar para o menu anterior\n" +
        "---------------------\n" +
        "Categoria  Exemplares\n" + 
        "---------------------\n" +
        "02 = Inserir exemplar\n" +
        "03 = Listar exemplar\n" +
        "04 = Atualizar exemplar\n" +
        "05 = Excluir exemplar"
        );
        op = int.Parse(Console.ReadLine());
        if (op == 0) return 0;
        if (op == 1) {
          Console.Clear();
          op = Menu();
        }
        switch(op) {
        case 2: return 5;
        case 3: return 6;
        case 4: return 7;
        case 5: return 8;
        }
      }
      if (op == 3) {
        Console.WriteLine(
        "00 = Sair do programa\n" +
        "01 = Voltar para o menu anterior\n" +
        "---------------------\n" +
        "  Categoria Locação\n" + 
        "---------------------\n" +
        "02 = Inserir locação\n" +
        "03 = Listar locação\n" +
        "04 = Atualizar locação\n" +
        "05 = Excluir locação"
        );
        op = int.Parse(Console.ReadLine());
        if (op == 0) return 0;
        if (op == 1) {
          Console.Clear();
          op = Menu();
        }
        switch(op) {
        case 2: return 9;
        case 3: return 10;
        case 4: return 11;
        case 5: return 12;
        }
      }
      if (op == 4) {
        Console.WriteLine(
        "00 = Sair do programa\n" +
        "01 = Voltar para o menu anterior\n" +
        "---------------------\n" +
        "  Categoria Locador\n" + 
        "---------------------\n" +
        "02 = Inserir locador\n" +
        "03 = Listar locador\n" +
        "04 = Atualizar locador\n" +
        "05 = Excluir locador"
        );
        op = int.Parse(Console.ReadLine());
        if (op == 0) return 0;
        if (op == 1) {
          Console.Clear();
          op = Menu();
        }
        switch(op) {
        case 2: return 13;
        case 3: return 14;
        case 4: return 15;
        case 5: return 16;
        }
      }
      return op;
    }
    public static void LivroInserir() {
      
      string t, v, e, a, d, i;
      
      Console.Clear();
      Console.WriteLine("Digite o título do livro:");
      t = Console.ReadLine();
      Console.WriteLine("Digite o volume do livro:");
      v = Console.ReadLine();
      Console.WriteLine("Digite a edição do livro:");
      e = Console.ReadLine();
      Console.WriteLine("Digite o autor do livro:");
      a = Console.ReadLine();
      Console.WriteLine("Digite a descrição do livro:");
      d = Console.ReadLine();
      Console.WriteLine("Digite o ISBN do livro:");
      i = Console.ReadLine();
      Console.Clear();
      
      Livro livro = new Livro {Titulo = t, Volume = v, Edicao = e, Autor = a, Descricao = d, Isbn = i};
      NLivro.LivroInserir(livro);
      Console.WriteLine("Livro inserido\n");
    }
    public static void LivroListar() {
      Console.Clear();
      foreach (Livro livro in NLivro.LivroListar()) 
        Console.WriteLine(livro + "\n");  
    }
    public static void LivroAtualizar() {
      
      int id;
      string t, v, e, a, d, i;
      
      Console.Clear();
      Console.WriteLine("Digite o id do livro:");
      id = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o título do livro:");
      t = Console.ReadLine();
      Console.WriteLine("Digite o volume do livro:");
      v = Console.ReadLine();
      Console.WriteLine("Digite a edição do livro:");
      e = Console.ReadLine();
      Console.WriteLine("Digite o autor do livro:");
      a = Console.ReadLine();
      Console.WriteLine("Digite a descrição do livro:");
      d = Console.ReadLine();
      Console.WriteLine("Digite o ISBN do livro:");
      i = Console.ReadLine();
      Console.Clear();
      
      Livro livro = new Livro {Id = id, Titulo = t, Volume = v, Edicao = e, Autor = a, Descricao = d, Isbn = i};
      NLivro.LivroAtualizar(livro);
      Console.WriteLine("Livro atualizado\n");
    }
    public static void LivroApagar() {
      Console.Clear();
      Console.WriteLine("Informe o Id do livro a ser excluído");
      int id = int.Parse(Console.ReadLine());
      Console.Clear();
      Console.WriteLine("Tem certeza que deseja excluir o livro (s/n)?");
      Livro livro = new Livro {Id = id};
      Console.WriteLine(NLivro.LivroListar(id));
      string ans = Console.ReadLine();
      Console.Clear();
      if (ans == "n") Console.WriteLine("Exclusão cancelada");
      if (ans == "s") {
        NLivro.LivroExcluir(livro);
        Console.WriteLine("Livro excluído");
      }
    }
    public static void ExemplarInserir() {
      string ans;
      int idLivro;
      bool a = false;
      
      Console.Clear();
      Console.WriteLine("Digite o id do livro:");
      idLivro = int.Parse(Console.ReadLine());
      Console.WriteLine("O livro está alugado (s/n)?");
      ans = Console.ReadLine();
      if (ans == "s") a = true;
      Console.Clear();
      
      Exemplar exemplar = new Exemplar {Alugado = a, IdLivro = idLivro};
      NExemplar.ExemplarInserir(exemplar);
      Console.WriteLine("Exemplar inserido\n");
    }
    public static void ExemplarListar() {
      Console.Clear();
      foreach (Exemplar exemplar in NExemplar.ExemplarListar()) 
        Console.WriteLine(exemplar + "\n");  
    }
    public static void ExemplarAtualizar() {
      string ans;
      int id, idLivro;
      bool a = false;
      
      Console.Clear();
      Console.WriteLine("Digite o id do exemplar:");
      id = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o id do livro:");
      idLivro = int.Parse(Console.ReadLine());
      Console.WriteLine("O livro está alugado (s/n)?");
      ans = Console.ReadLine();
      if (ans == "s") a = true;
      Console.Clear();
      
      Exemplar exemplar = new Exemplar {Id = id, Alugado = a, IdLivro = idLivro};
      NExemplar.ExemplarAtualizar(exemplar);
      Console.WriteLine("Exemplar atualizado\n");
    }
    public static void ExemplarApagar() {
      Console.Clear();
      Console.WriteLine("Informe o Id do exemplar a ser excluído");
      int id = int.Parse(Console.ReadLine());
      Console.Clear();
      Console.WriteLine("Tem certeza que deseja excluir o exemplar (s/n)?");
      Exemplar exemplar = new Exemplar {Id = id};
      Console.WriteLine(NExemplar.ExemplarListar(id));
      string ans = Console.ReadLine();
      Console.Clear();
      if (ans == "n") Console.WriteLine("Exclusão cancelada");
      if (ans == "s") {
        NExemplar.ExemplarExcluir(exemplar);
        Console.WriteLine("Exemplar excluído");
      }
    }
    public static void LocacaoInserir() {}
    public static void LocacaoListar() {}
    public static void LocacaoAtualizar() {}
    public static void LocacaoApagar() {}
    public static void LocadorInserir() {}
    public static void LocadorListar() {}
    public static void LocadorAtualizar() {}
    public static void LocadorApagar() {}
    public static void Devolucao() {}
    
  }
}
