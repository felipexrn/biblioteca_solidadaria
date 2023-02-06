using System;
using Modelo;
using Negocio;
//using System.Threading;
namespace Visao {
  class Biblioteca {
    public static void Main() {
      string mensagem = 
        "----------------------\n" +
        " BIBLIOTECA SOLIDÁRIA \n" +
        "----------------------\n" +
        "IFRN CNAT - Curso de TADS - Disciplina de POO\n" +
        "Professor: Gilbert Silva\n" +
        "Projeto: Implementação de sistema orietado a objetos\n" +
        "Alunos: Elton da Silva e Felipe Xavier\n" +
        "Disponível em: github.com/felipexrn/biblioteca_solidaria\n";
      /*Console.Clear();
      Console.WriteLine(mensagem);
      Thread.Sleep(2000);*/
      Console.Clear();
      int op = Menu(); 
      while(op!=0) {
        try {
          switch(op) {
            case 1: LivroInserir(); break; // Implementado
            case 2: LivroListar(); break;  // Implementado
            case 3: LivroAtualizar(); break;  // Implementado
            case 4: LivroApagar(); break;  // Implementado
            case 5: LivroPesquisarTitulo(); break; // Implementado
            case 6: LivroPesquisarAutor(); break; // Implementado
            
            case 7: ExemplarInserir(); break; // Implementado
            case 8: ExemplarListar(); break; // Implementado
            case 9: ExemplarAtualizar(); break; // Implementado
            case 10: ExemplarApagar(); break; // Implementado
            case 11: ExemplarDevolver(); break; // Implementado
            
            case 12: LocacaoInserir(); break;
            case 13: LocacaoListar(); break;
            case 14: LocacaoAtualizar(); break;
            case 15: LocacaoApagar(); break;
            case 16: LocacaoOrdenarDataDev(); break;
            case 17: LocacaoOrdenarDataLoc(); break;
            
            case 18: LocadorInserir(); break;
            case 19: LocadorListar(); break;
            case 20: LocadorAtualizar(); break;
            case 21: LocadorApagar(); break;
            case 22: LocadorPesquisar(); break;
          }
        }
        catch (Exception erro) {
          Console.WriteLine(erro.Message + "\n");
        }
        op = Menu();
      }
      Console.Clear();
      Console.WriteLine(mensagem);
      Console.WriteLine("Programa encerrado.");
    }
    public static int Menu() {
      int op;
      Console.WriteLine(
        " BIBLIOTECA SOLIDÁRIA\n" +
        "----------------------\n" +
        "         Menu\n" + 
        "----------------------\n" +
        "00 = Sair do programa\n" +
        "01 = Livros\n" +
        "02 = Exemplares\n" +
        "03 = Locação\n" +
        "04 = Locadores"
      );
      op = int.Parse(Console.ReadLine());
      if (op > 4 || op < 0) {
        Console.Clear();
        Console.WriteLine("Valor escolhido é inválido\n");
        op = Menu();
      }
      Console.Clear();
      if (op == 0) return op;
      if (op == 1) {
        Console.WriteLine(
        " BIBLIOTECA SOLIDÁRIA\n" +
        "----------------------\n" +
        "         Menu\n" + 
        "----------------------\n" +
        "00 = Sair do programa\n" +
        "01 = Voltar para o menu\n" +
        "---------------------\n" +
        "  Categoria  Livros\n" + 
        "---------------------\n" +
        "02 - Inserir livro\n" +
        "03 - Listar livros\n" +
        "04 - Atualizar livro\n" +
        "05 - Excluir livro\n" + 
        "06 - Pesquisar Título\n" +
        "07 - Pesquisar Autor(a)"
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
          case 6: return 5;
          case 7: return 6;
        }
      }
      if (op == 2) {
        Console.WriteLine(
        " BIBLIOTECA SOLIDÁRIA\n" +
        "----------------------\n" +
        "         Menu\n" + 
        "----------------------\n" +
        "00 = Sair do programa\n" +
        "01 = Voltar para o menu\n" +
        "---------------------\n" +
        "Categoria  Exemplares\n" + 
        "---------------------\n" +
        "02 = Inserir exemplar\n" +
        "03 = Listar exemplares\n" +
        "04 = Atualizar exemplar\n" +
        "05 = Excluir exemplar\n" + 
        "06 = Devolver exemplar"
        );
        op = int.Parse(Console.ReadLine());
        if (op == 0) return 0;
        if (op == 1) {
          Console.Clear();
          op = Menu();
        }
        switch(op) {
        case 2: return 7;
        case 3: return 8;
        case 4: return 9;
        case 5: return 10;
        case 6: return 11;
        }
      }
      if (op == 3) {
        Console.WriteLine(
        " BIBLIOTECA SOLIDÁRIA\n" +
        "----------------------\n" +
        "         Menu\n" + 
        "----------------------\n" +
        "00 = Sair do programa\n" +
        "01 = Voltar para o menu\n" +
        "---------------------\n" +
        "  Categoria Locação\n" + 
        "---------------------\n" +
        "02 = Inserir locação\n" +
        "03 = Listar locação\n" +
        "04 = Atualizar locação\n" +
        "05 = Excluir locação\n" +
        "06 = Ordenar data devolução\n" +
        "07 = Ordenar data Locação"
        );
        op = int.Parse(Console.ReadLine());
        if (op == 0) return 0;
        if (op == 1) {
          Console.Clear();
          op = Menu();
        }
        switch(op) {
        case 2: return 12;
        case 3: return 13;
        case 4: return 14;
        case 5: return 15;
        case 6: return 16;
        case 7: return 17;
        }
      }
      if (op == 4) {
        Console.WriteLine(
        " BIBLIOTECA SOLIDÁRIA\n" +
        "----------------------\n" +
        "         Menu\n" + 
        "----------------------\n" +
        "00 = Sair do programa\n" +
        "01 = Voltar para o menu\n" +
        "----------------------\n" +
        " Categoria Locador(a)\n" + 
        "----------------------\n" +
        "02 = Inserir locador(a)\n" +
        "03 = Listar locador(a)\n" +
        "04 = Atualizar locador(a)\n" +
        "05 = Excluir locador(a)\n" + 
        "06 = Pesquisar locador(a)"
        );
        op = int.Parse(Console.ReadLine());
        if (op == 0) return 0;
        if (op == 1) {
          Console.Clear();
          op = Menu();
        }
        switch(op) {
        case 2: return 18;
        case 3: return 19;
        case 4: return 20;
        case 5: return 21;
        case 6: return 22;
        }
      }
      return op;
    }
    public static void LivroInserir() {
      
      string t, v, e, a, d, i;
      
      Console.Clear();
      Console.WriteLine(
        "------------------\n" +
        "02 - Inserir livro\n" +
        "------------------\n"
        );
      Console.WriteLine("Digite o título do livro:");
      t = Console.ReadLine();
      Console.WriteLine("Digite o volume do livro:");
      v = Console.ReadLine();
      Console.WriteLine("Digite a edição do livro:");
      e = Console.ReadLine();
      Console.WriteLine("Digite o(a) autor(a) do livro:");
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
      Console.WriteLine(
        "------------------\n" +
        "03 - Listar livros\n" +
        "------------------\n"
        );
      foreach (Livro livro in NLivro.LivroListar()) 
        Console.WriteLine(
          livro + "\n" +
          "Exemplares: " + NExemplar.ExemplarContarIdLivro(livro.Id).ToString() + "\n" +
            "Disponíveis: " + NExemplar.ExemplarContarAlugado(livro.Id).ToString() + "\n");  
    }
    public static void LivroAtualizar() {
      
      int id;
      string t, v, e, a, d, i;
      
      Console.Clear();
      Console.WriteLine(
        "--------------------\n" +
        "04 - Atualizar livro\n" +
        "--------------------\n"
        );
      Console.WriteLine("Digite o id do livro:");
      id = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o título do livro:");
      t = Console.ReadLine();
      Console.WriteLine("Digite o volume do livro:");
      v = Console.ReadLine();
      Console.WriteLine("Digite a edição do livro:");
      e = Console.ReadLine();
      Console.WriteLine("Digite o(a) autor(a) do livro:");
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
      Console.WriteLine(
        "------------------\n" +
        "05 - Excluir livro\n" +
        "------------------\n"
        );
      Console.WriteLine("Informe o Id do livro a ser excluído");
      int id = int.Parse(Console.ReadLine());
      Console.WriteLine("Tem certeza que deseja excluir o livro (s/n)?");
      Livro livro = new Livro {Id = id};
      Console.WriteLine(NLivro.LivroListar(id));
      string ans = Console.ReadLine();
      Console.Clear();
      if (ans == "n") Console.WriteLine("Exclusão cancelada\n");
      if (ans == "s") {
        NLivro.LivroExcluir(livro);
        Console.WriteLine("Livro excluído\n");
      }
    }
    public static void LivroPesquisarTitulo() {
      string t;
      Console.Clear();
      Console.WriteLine(
        "---------------------\n" +
        "06 - Pesquisar Título\n" +
        "---------------------\n"
        );
      Console.WriteLine("Digite o título do livro:");
      t = Console.ReadLine();
      Console.Clear();
      if (NLivro.LivroPesquisarTitulo(t).Count > 0) {
        foreach(Livro livro in NLivro.LivroPesquisarTitulo(t)) {
          Console.WriteLine(
            livro + "\n" +
            "Exemplares: " + NExemplar.ExemplarContarIdLivro(livro.Id).ToString() + "\n" +
            "Disponíveis: " + NExemplar.ExemplarContarAlugado(livro.Id).ToString() +
            "\n");
        }
      } else Console.WriteLine("Título não encontrado\n");
      
    }
    public static void LivroPesquisarAutor() {
      string a;
      Console.Clear();
      Console.WriteLine(
        "----------------------\n" +
        "07 - Pesquisar Autor(a)\n" +
        "----------------------\n"
        );
      Console.WriteLine("Digite o(a) autor(a) do livro:");
      a = Console.ReadLine();
      Console.Clear();
      if (NLivro.LivroPesquisarAutor(a).Count > 0) {
        foreach(Livro livro in NLivro.LivroPesquisarAutor(a)) {
          Console.WriteLine(
            livro + "\n" +
            "Exemplares: " + NExemplar.ExemplarContarIdLivro(livro.Id).ToString() + "\n" +
            "Disponíveis: " + NExemplar.ExemplarContarAlugado(livro.Id).ToString() +
            "\n");
        }
      } else Console.WriteLine("Autor não encontrado\n");
      
    }
    public static void ExemplarInserir() {
      string ans;
      int idLivro;
      string a = "Não";
      
      Console.Clear();
      Console.WriteLine(
        "---------------------\n" +
        "02 - Inserir exemplar\n" +
        "---------------------\n"
        );
      Console.WriteLine("Digite o id do livro:");
      idLivro = int.Parse(Console.ReadLine());
      Console.WriteLine("O livro está alugado (s/n)?");
      ans = Console.ReadLine();
      if (ans == "s") a = "Sim";
      Console.Clear();
      
      Exemplar exemplar = new Exemplar {Alugado = a, IdLivro = idLivro};
      NExemplar.ExemplarInserir(exemplar);
      Console.WriteLine("Exemplar inserido\n");
    }
    public static void ExemplarListar() {
      Console.Clear();
      Console.WriteLine(
        "----------------------\n" +
        "03 - Listar exemplares\n" +
        "----------------------\n"
        );
      foreach (Exemplar exemplar in NExemplar.ExemplarListar()) 
        Console.WriteLine(
          exemplar + "\n" + 
          NLivro.LivroListar(exemplar.IdLivro) + 
          "\n");  
    }
    public static void ExemplarAtualizar() {
      string ans;
      int id, idLivro;
      string a = "Não";
      
      Console.Clear();
      Console.WriteLine(
        "-----------------------\n" +
        "04 - Atualizar exemplar\n" +
        "-----------------------\n"
        );
      Console.WriteLine("Digite o id do exemplar:");
      id = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o id do livro:");
      idLivro = int.Parse(Console.ReadLine());
      Console.WriteLine("O livro está alugado (s/n)?");
      ans = Console.ReadLine();
      if (ans == "s") a = "Sim";
      Console.Clear();
      
      Exemplar exemplar = new Exemplar {Id = id, Alugado = a, IdLivro = idLivro};
      NExemplar.ExemplarAtualizar(exemplar);
      Console.WriteLine("Exemplar atualizado\n");
    }
    public static void ExemplarApagar() {
      Console.Clear();
      Console.WriteLine(
        "---------------------\n" +
        "05 - Excluir exemplar\n" +
        "---------------------\n"
        );
      Console.WriteLine("Informe o Id do exemplar a ser excluído");
      int id = int.Parse(Console.ReadLine());
      Console.WriteLine("Tem certeza que deseja excluir o exemplar (s/n)?");
      Exemplar exemplar = new Exemplar {Id = id};
      Console.WriteLine(NExemplar.ExemplarListar(id));
      string ans = Console.ReadLine();
      Console.Clear();
      if (ans == "n") Console.WriteLine("Exclusão cancelada\n");
      if (ans == "s") {
        NExemplar.ExemplarExcluir(exemplar);
        Console.WriteLine("Exemplar excluído\n");
      }
    }
    public static void ExemplarDevolver() {
      int id;
      
      Console.Clear();
      Console.WriteLine(
        "----------------------\n" +
        "06 - Devolver exemplar\n" +
        "----------------------\n"
        );
      Console.WriteLine("Digite o id do exemplar:");
      id = int.Parse(Console.ReadLine());
      Console.Clear();
      
      Exemplar exemplar = new Exemplar {Id = id, Alugado = "Não"};
      NExemplar.ExemplarAtualizar(exemplar);
      Console.WriteLine("Exemplar devolvido\n");
    }
    public static void LocacaoInserir() {Console.Clear();}
    public static void LocacaoListar() {Console.Clear();}
    public static void LocacaoAtualizar() {Console.Clear();}
    public static void LocacaoApagar() {Console.Clear();}
    public static void LocacaoOrdenarDataDev() {Console.Clear();}
    public static void LocacaoOrdenarDataLoc() {Console.Clear();}
    public static void LocadorInserir() {Console.Clear();}
    public static void LocadorListar() {Console.Clear();}
    public static void LocadorAtualizar() {Console.Clear();}
    public static void LocadorApagar() {Console.Clear();}
    public static void LocadorPesquisar() {Console.Clear();}
  }
}
