using System;
namespace Modelo {
  public class Exemplar {
    public int IdExemplar {get; set;} /*implementar*/
    public string Alugado {get; set;} /*implementar*/
    public int IdLivro {get; set;} /*implementar*/
    public Exemplar() {}
    public Exemplar(int id, string a, int idLivro) {
      IdExemplar= id;
      Alugado = a;
      IdLivro = idLivro;
    }
    public Exemplar(string a, int idLivro) {
      Alugado = a;
      IdLivro = idLivro;
    }
    public override string ToString() {
      return $"Id Exemplar: {this.IdExemplar}\nAlugado: {this.Alugado}\nId Livro: {this.IdLivro}";  
    }
  }
}
