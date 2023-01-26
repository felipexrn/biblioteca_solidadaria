using System;
namespace Modelo {
  public class Locacao {
    public int Id {get;set;}
    public DateTime DataLocacao {get;set;}
    public int IdExemplar {get;set;}
    public int IdLocador {get;set;}
    private DateTime dataDevolucao;//Perguntar si inclui no construtor ToString
    public Locacao(){}
    public Locacao(int id, DateTime dataLoc, int idExemplar,int idLocador){
      Id = id;
      DataLocacao = dataLoc;
      IdExemplar = idExemplar;
      IdLocador = idLocador;
    }
    public Locacao (DateTime dataLoc, int idExemplar, int idLocador){
      DataLocacao = dataLoc;
      IdExemplar = idExemplar;
      IdLocador = idLocador;
    }
    public override string ToString(){
      return $"Id: {this.Id}\nData de Locacao: {this.DataLocacao}\nId Exemplar: {this.IdExemplar}\nId Locador: {this.IdLocador}";
    }
  }
}
