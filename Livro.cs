using System;
using System.Collections;
namespace Modelo {
  public class Livro : IComparable {
    public int Id {get; set;} /*implementar*/
    public string Titulo {get; set;} /*implementar*/
    public string Volume {get; set;} /*implementar*/
    public string Edicao {get; set;} /*implementar*/
    public string Autor {get; set;} /*implementar*/
    public string Descricao {get; set;} /*implementar*/
    public string Isbn {get; set;} /*implementar*/
    public Livro() {}
    public Livro(int id, string t, string v, string e, string a, string d, string i) {
      Id = id;
      Titulo = t;
      Volume = v;
      Edicao = e;
      Autor = a;
      Descricao = d;
      Isbn = i;
    }
    public Livro(string t, string v, string e, string a, string d, string i) {
      Titulo = t;
      Volume = v;
      Edicao = e;
      Autor = a;
      Descricao = d;
      Isbn = i;
    }
    public override string ToString() {
      return $"Id Livro: {this.Id}\nTitulo: {this.Titulo}\nVolume: {this.Volume}\nEdição: {this.Edicao}\nAutor: {this.Autor}\nDescricao: {this.Descricao}\nIsbn: {this.Isbn}";
    }
    public int CompareTo(object obj) {
      Livro l2 = (Livro) obj;
      return this.Titulo.CompareTo(l2.Titulo);
    }
  }
  public class CompAutor : IComparer {
    public int Compare(object obj1, object obj2) {
      Livro l1 = (Livro) obj1;
      Livro l2 = (Livro) obj2;
      return l1.Autor.CompareTo(l2.Autor);
    }
  }
}