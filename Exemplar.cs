using System;
namespace Modelo {
  public class Exemplar {
    public int Id {get; set;} /*implementar*/
    public string Alugado {get; set;} /*implementar*/
    public int IdLivro {get; set;} /*implementar*/
    public Exemplar() {}
    public Exemplar(int id, string a, int idLivro) {
      Id = id;
      Alugado = a;
      IdLivro = idLivro;
    }
    public Exemplar(string a, int idLivro) {
      Alugado = a;
      IdLivro = idLivro;
    }
    public override string ToString() {
      return $"Id Exemplar: {this.Id}\nAlugado: {this.Alugado}\nId Livro: {this.IdLivro}";  
    }
  }
}
