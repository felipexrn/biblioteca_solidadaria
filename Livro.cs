using System;
namespace Modelo {
  public class Livro : IComparable {
    public int Id {get; set;}
    public string Titulo {get; set;}
    /*
    try {
      // Código protegido – fluxo normal da aplicação
    }
    catch {
      // Código do tratamento de erro – fluxo de exceção
    }
    */
    public string Autor {get; set;} /*implementar*/
    public string Descricao {get; set;} /*implementar*/
    public string Isbn {get; set;} /*implementar*/
    public Livro() {}
    public Livro(string t, string a, string d, string i) {/*implementar*/}
    public override string ToString() {/*implementar*/}
    public int CompareTo(object obj) {
      Livro l2 = (Livro) obj;
      return this.Titulo.CompareTo(l2.Titulo);
    }
  }
  public class CompAutor : IComparer {
    public int Compare(object obj1, object obj2) {
      Livro l1 (Livro) = obj1;
      Livro l2 (Livro) = obj2;
      return l1.Autor.CompareTo(l2.Autor);
    }
  }
}