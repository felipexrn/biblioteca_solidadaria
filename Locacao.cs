using System;
namespace Modelo {
  public class Locacao: IComparable {
    public int Id {get;set;}
    public DateTime DataLocacao {get;set;}
    public int IdExemplar {get;set;}
    public int IdLocador {get;set;}
    private DateTime dataDevolucao;
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
      return $"Id: {this.Id}\nData de Locacao: {this.Data de Locacao}\nId Exemplar: {this.Id Exemplar}\nId Locador: {this.Id Locador}\nData de Devolucao: {this.dataDevolucao}";
    }
    public int CompareTo(object obj){
      Locacao l1 = (Locacao) obj;
      return this.dataDevolucao.CompareTo(l1.dataDevolucao);
    }
  }
}
