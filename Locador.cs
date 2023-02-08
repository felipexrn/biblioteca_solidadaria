using System;
namespace Modelo {
  public class Locador: IComparable {
    public int Id{get;set;}
    public string Nome{get;set;}
    public string Telefone{get;set;}
    public Locador (){}
    public Locador(int id, string n, string t) {
      Id = id;
      Nome = n;
      Telefone = t;
    }
    public Locador(string n, string t){
      Nome = n;
      Telefone = t;
    }
    public override string ToString(){
      return $"Id: {this.Id}\nNome: {this.Nome}\nTelefone: {this.Telefone}";
    }
    public int CompareTo(object obj){
      Locador l1 = (Locador) obj;
      return this.Nome.CompareTo(l1.Nome);
    }
  }
}
