using System;
namespace Modelo {
  public class Exemplar {
    public int Id {get; set;} /*implementar*/
    public bool Alugado {get; set;} /*implementar*/
    public int IdLivro {get; set;} /*implementar*/
    public Exemplar() {}
    public Exemplar(bool a, int idLivro) {/*implementar*/}
    public override string ToString() {
      return $"Id: {this.Id}\nAlugado: {this.Alugado}\nIdLivro: {this.IdLivro}";  
    }
  }
}
