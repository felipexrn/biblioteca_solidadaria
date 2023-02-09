using System;
using System.Globalization;
using Modelo;
using Negocio;
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
      Console.Clear();
      int op = Menu(); 
      while(op!=0) {
        try {
          switch(op) {
            case 1: LivroInserir(); break; // Implementado
            case 2: LivroListar(); break;  // Implementado
            case 3: LivroAtualizar(); break;  // Implementado
            case 4: LivroExcluir(); break;  // Implementado
            case 5: LivroPesquisarTitulo(); break; // Implementado
            case 6: LivroPesquisarAutor(); break; // Implementado
            
            case 7: ExemplarInserir(); break; // Implementado
            case 8: ExemplarListar(); break; // Implementado
            case 9: ExemplarAtualizar(); break; // Implementado
            case 10: ExemplarExcluir(); break; // Implementado
            case 11: ExemplarDevolver(); break; // Implementado
            
            case 12: LocacaoInserir(); break; // Implementado
            case 13: LocacaoListar(); break; // Implementado
            case 14: LocacaoAtualizar(); break; // Implementado
            case 15: LocacaoExcluir(); break; // Implementado
            case 16: LocacaoOrdenarDataDevCres(); break; // Implementado
            case 17: LocacaoOrdenarDataDevDecres(); break; // Implementado
            
            case 18: LocadorInserir(); break; // Implementado
            case 19: LocadorListar(); break; // Implementado
            case 20: LocadorAtualizar(); break; // Implementado
            case 21: LocadorExcluir(); break; // Implementado
            case 22: LocadorPesquisar(); break; // Implementado
            }
        }
        catch (Exception erro) {
          Console.Clear();
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
        "06 = Ordenar data devolução crecente\n" +
        "07 = Ordenar data devolução decrescente"
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
      Console.WriteLine(livro + "\n");
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
          "Exemplares: " + NExemplar.ExemplarContarIdLivro(livro.IdLivro).ToString() + "\n" +
            "Disponíveis: " + NExemplar.ExemplarContarAlugado(livro.IdLivro).ToString() + "\n");  
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
      
      Livro livro = new Livro {IdLivro = id, Titulo = t, Volume = v, Edicao = e, Autor = a, Descricao = d, Isbn = i};
      NLivro.LivroAtualizar(livro);
      Console.WriteLine(livro + "\n");
      Console.WriteLine("Livro atualizado\n");
    }
    public static void LivroExcluir() {
      Console.Clear();
      Console.WriteLine(
        "------------------\n" +
        "05 - Excluir livro\n" +
        "------------------\n"
        );
      Console.WriteLine("Informe o Id do livro a ser excluído");
      int id = int.Parse(Console.ReadLine());
      Livro livro = new Livro {IdLivro = id};
      Console.WriteLine(NLivro.LivroListar(id) + "\n");
      Console.WriteLine("Tem certeza que deseja excluir o livro (s/n)?");
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
            "Exemplares: " + NExemplar.ExemplarContarIdLivro(livro.IdLivro).ToString() + "\n" +
            "Disponíveis: " + NExemplar.ExemplarContarAlugado(livro.IdLivro).ToString() +
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
            "Exemplares: " + NExemplar.ExemplarContarIdLivro(livro.IdLivro).ToString() + "\n" +
            "Disponíveis: " + NExemplar.ExemplarContarAlugado(livro.IdLivro).ToString() +
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
      if (NLivro.LivroExiste(idLivro)) {
        NExemplar.ExemplarInserir(exemplar);
        Console.WriteLine(exemplar + "\n");
        Console.WriteLine("Exemplar inserido\n");
      } else {
         throw new ArgumentException("Id de livro não encontrado.");
      }
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
          "Títuo: " + NLivro.LivroListar(exemplar.IdLivro).Titulo + 
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
      
      Exemplar exemplar = new Exemplar {IdExemplar = id, Alugado = a, IdLivro = idLivro};
      NExemplar.ExemplarAtualizar(exemplar);
      Console.WriteLine(exemplar + "\n");
      Console.WriteLine("Exemplar atualizado\n");
    }
    public static void ExemplarExcluir() {
      Console.Clear();
      Console.WriteLine(
        "---------------------\n" +
        "05 - Excluir exemplar\n" +
        "---------------------\n"
        );
      Console.WriteLine("Informe o Id do exemplar a ser excluído");
      int id = int.Parse(Console.ReadLine());
      Console.WriteLine("Tem certeza que deseja excluir o exemplar (s/n)?");
      Exemplar exemplar = new Exemplar {IdExemplar = id};
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
      Exemplar exemplar = NExemplar.ExemplarListar(id);
      exemplar.Alugado = "Não";
      NExemplar.ExemplarAtualizar(exemplar);
      Console.WriteLine(
        exemplar + "\n" + 
        NLivro.LivroListar(exemplar.IdLivro) + "\n" +
        "\n"
        );
      Console.WriteLine("Exemplar devolvido\n");
    }
    public static void LocacaoInserir() {
      Console.Clear();
      Console.WriteLine(
        "--------------------\n" +
        "02 - Inserir locação\n" +
        "--------------------\n"
        );
      DateTime dataLoc = DateTime.Now;
      Console.WriteLine("Digite o id do exemplar:");
      int idExemplar = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o id do locador:");
      int idLocador = int.Parse(Console.ReadLine());
      Locacao locacao = new Locacao(dataLoc, idExemplar, idLocador);
      NLocacao.LocacaoInserir(locacao);
      Console.Clear();
      Console.WriteLine(locacao + "\n");
      Console.WriteLine("Locacao realizada\n");
    }
    public static void LocacaoListar() {
      Console.Clear();
      Console.WriteLine(
        "--------------------\n" +
        "03 - Listar locações\n" +
        "--------------------\n"
        );
      foreach (Locacao locacao in NLocacao.LocacaoListar()) 
        Console.WriteLine(
          locacao + "\n" +
          "Título: " + NLivro.LivroListar(NExemplar.ExemplarListar(locacao.IdExemplar).IdLivro).Titulo + "\n" +
          "Alugado: " + NExemplar.ExemplarListar(locacao.IdExemplar).Alugado + "\n" + 
          "Locador(a): " + NLocador.LocadorListar(locacao.IdLocador).Nome +
          "\n");  
      }
    public static void LocacaoAtualizar() {
      Console.Clear();
      Console.WriteLine(
        "----------------------\n" +
        "02 - Atualizar locação\n" +
        "----------------------\n"
        );
      Console.WriteLine("Digite o id da locação:");
      int idLocacao = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o id do exemplar:");
      int idExemplar = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite a data da locação (dd/mm/aaaa):");
      string dateString = Console.ReadLine();
      DateTime dataLoc = new DateTime();
      try {
        dataLoc = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
      } catch (ArgumentException e) {
        Console.WriteLine("Formato inválido de data" + e);
      }
      Console.WriteLine("Digite o id do locador:");
      int idLocador = int.Parse(Console.ReadLine());
      Locacao locacao = new Locacao(idLocacao, dataLoc, idExemplar, idLocador);
      NLocacao.LocacaoAtualizar(locacao);
      Console.Clear();
      Console.WriteLine(locacao + "\n");
      Console.WriteLine("Locacao atualizada\n");
      }
    public static void LocacaoExcluir() {
      Console.Clear();
      Console.WriteLine(
        "--------------------\n" +
        "05 - Excluir locação\n" +
        "--------------------\n"
        );
      Console.WriteLine("Informe o Id da locação a ser excluída");
      int id = int.Parse(Console.ReadLine());
      Console.WriteLine(NLocacao.LocacaoListar(id));
      Console.WriteLine("Tem certeza que deseja excluir esta locação (s/n)?");
      string ans = Console.ReadLine();
      Locacao locacao = new Locacao {IdLocacao = id};
      Console.Clear();
      if (ans == "n") Console.WriteLine("Exclusão cancelada\n");
      if (ans == "s") {
        NLocacao.LocacaoExcluir(locacao);
        Console.WriteLine("Locação excluída\n");
      } else {
        throw new ArgumentException("Opção inválida");
      }
    }
    public static void LocacaoOrdenarDataDevCres() {
      Console.Clear();
      Console.WriteLine(
        "--------------------------------\n" +
        "06 - Ordenar locação - crescente\n" +
        "--------------------------------\n"
        );
      Console.WriteLine("Locações ordenadas da mais antiga para mais nova\n");
      NLocacao.LocacaoOrdenarDataDevCres();
    }
    public static void LocacaoOrdenarDataDevDecres() {
      Console.Clear();
      Console.WriteLine(
        "----------------------------------\n" +
        "07 - Ordenar locação - decrescente\n" +
        "----------------------------------\n"
        );
      Console.WriteLine("Locações ordenadas da mais nova para mais antiga\n");
      NLocacao.LocacaoOrdenarDataDevDecres();
    }
    public static void LocadorInserir() {
      string n, t;
      
      Console.Clear();
      Console.WriteLine(
        "----------------------\n" +
        "02 - Inserir locador(a)\n" +
        "----------------------\n"
        );
      Console.WriteLine("Digite o nome do(a) locador(a):");
      n = Console.ReadLine();
      Console.WriteLine("Digite o telefone de contato do(a) locador(a):");
      t = Console.ReadLine();
      Console.Clear();
      
      Locador locador = new Locador {Nome = n, Telefone = t};
      NLocador.LocadorInserir(locador);
      Console.WriteLine(locador + "\n");
      Console.WriteLine("Locador(a) inserido\n");
    }
    public static void LocadorListar() {
      Console.Clear();
      Console.WriteLine(
        "---------------------\n" +
        "03 - Listar locadores\n" +
        "---------------------\n"
        );
      foreach (Locador locador in NLocador.LocadorListar()) 
        Console.WriteLine(
          locador + /*"\n" +
          "Qtd exemplares alugados: " +
          NLocacao.LocacaoContarLocadorAlugado(locador.IdLocador) +*/
          "\n");
      }
    public static void LocadorAtualizar() {
      int id;
      string n, t;
      
      Console.Clear();
      Console.WriteLine(
        "------------------------\n" +
        "02 - Atualizar locador(a)\n" +
        "------------------------\n"
        );
      Console.WriteLine("Digite o id do(a) locador(a):");
      id = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o nome do(a) locador(a):");
      n = Console.ReadLine();
      Console.WriteLine("Digite o telefone de contato do(a) locador(a):");
      t = Console.ReadLine();
      Console.Clear();
      
      Locador locador = new Locador {IdLocador = id, Nome = n, Telefone = t};
      NLocador.LocadorAtualizar(locador);
      Console.WriteLine(locador + "\n");
      Console.WriteLine("Locador(a) Atualizado(a)\n");
      }
    public static void LocadorExcluir() {
      Console.Clear();
      Console.WriteLine(
        "----------------------\n" +
        "05 - Excluir locador(a)\n" +
        "----------------------\n"
        );
      Console.WriteLine("Informe o Id do(a) locador(a) a ser excluído");
      int id = int.Parse(Console.ReadLine());
      Locador locador = new Locador {IdLocador = id};
      Console.WriteLine(NLocador.LocadorListar(id) + "\n");
      Console.WriteLine("Tem certeza que deseja excluir o(a) locador(a) (s/n)?");
      string ans = Console.ReadLine();
      Console.Clear();
      if (ans == "n") Console.WriteLine("Exclusão cancelada\n");
      if (ans == "s") {
        NLocador.LocadorExcluir(locador);
        Console.WriteLine("Locador(a) excluído(a)\n");
      }
    }
    public static void LocadorPesquisar() {
      string n;
      Console.Clear();
      Console.WriteLine(
        "------------------------------\n" +
        "06 - Pesquisar nome Locador(a)\n" +
        "------------------------------\n"
        );
      Console.WriteLine("Digite o o nome do(a) locador(a):");
      n = Console.ReadLine();
      Console.Clear();
      if (NLocador.LocadorPesquisar(n).Count > 0) {
        foreach(Locador locador in NLocador.LocadorPesquisar(n)) {
          Console.WriteLine(
            locador + "\n" +
            "Qtd exemplares alugados: " +
            // implementar 
            "\n");
        }
      } else Console.WriteLine("Nome não encontrado\n");
    }
  }
}
