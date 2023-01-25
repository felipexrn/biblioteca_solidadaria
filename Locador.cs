using System;
namespace Modelo {
  public class Locador {
    public int Id{get;set;}
    public string Nome{get;set;}
    public string Telefone{get;set;}
    public Locador (){}
    public Locador(int id, string n, string t, int idLocacao) {
      Id = id;
      Nome = n;
      Telefone = t;
    }
    public Locador(string n, string t){
      Nome = n;
      Telefone = t;
    }
    public overside string ToString(){
      return $"Id: {this.Id}\nNome: {this.Nome}\nTelefone: {this.Telefone}";
    }
  }
}
