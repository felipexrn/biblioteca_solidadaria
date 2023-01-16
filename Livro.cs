using System;
namespace Modelo {
  public class Livro : IComparable {
    public int Id {get, set}
    public string Titulo {get, set} /*implementar*/
    public string Autor {get, set} /*implementar*/
    public string Descricao {get, set} /*implementar*/
    public string Isbn {get, set} /*implementar*/
    public Livro() {}
    public Livro(string t, string a, string d, string i) {/*implementar*/}
    public override string ToString() {/*implementar*/}
    public int CompareTo(object obj) {
      Livro l2 = (Livro) obj;
      return this.Titulo.CompareTo(l2.Titulo);
    }
  }
}