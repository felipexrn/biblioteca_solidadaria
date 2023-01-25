using System;
namespace Modelo {
  public class Exemplar {
    public int Id {get; set;} /*implementar*/
    public bool Alugado {get; set;} /*implementar*/
    public int IdLivro {get; set;} /*implementar*/
    public Exemplar() {}
    public Exemplar(int id, bool a, int idLivro) {
      Id = id;
      Alugado = a;
      IdLivro = idLivro;
    }
    public Exemplar(bool a, int idLivro) {
      Alugado = a;
      IdLivro = idLivro;
    }
    public override string ToString() {
      return $"Id: {this.Id}\nAlugado: {this.Alugado}\nIdLivro: {this.IdLivro}";  
    }
  }
}
