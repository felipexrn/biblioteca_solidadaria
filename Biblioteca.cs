using System;
using Modelo;
namespace Visao {
  class Biblioteca {
    public static void Main() {
      Livro l1 = new Livro {Id = 1, Titulo = "O sono dos justos", Autor = "Um Aluno exausto", Descricao = "Nada há nesse livro, pois o autor só estuda e trabalha...", Isbn = "2012548615168135168"};
      Console.WriteLine(l1.ToString());
      
      Exemplar e1 = new Exemplar {Id = 2, Alugado = true, IdLivro = 1};
      Console.WriteLine(e1.ToString());
    }
    public static void Menu() {}
    public static void LivroInserir() {}
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
