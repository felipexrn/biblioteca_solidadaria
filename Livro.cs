using System;
namespace Modelo {
  public class Livro {
    public int Id {get, set}
    public string Titulo {get, set}
    public string Autor {get, set}
    public string Descricao {get, set}
    public string Isbn {get, set}
    public Livro() {}
    public Livro(string t, string a, string d, string i) {/*implementar*/}
    public override string ToString() {/*implementar*/}
  }
}