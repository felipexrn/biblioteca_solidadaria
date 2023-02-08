using System;
using System.Collections;
namespace Modelo {
  public class Locacao: IComparable {
    public int Id {get;set;}
    public DateTime DataLocacao {get;set;}
    public int IdExemplar {get;set;}
    public int IdLocador {get;set;}
    public DateTime DataDevolucao {get;set;}
    public Locacao(){}
    public Locacao(int id, DateTime dataLoc, int idExemplar,int idLocador){
      Id = id;
      DataLocacao = dataLoc;
      IdExemplar = idExemplar;
      IdLocador = idLocador;
      DataDevolucao = dataLoc.AddDays(15);
    }
    public Locacao (DateTime dataLoc, int idExemplar, int idLocador){
      DataLocacao = dataLoc;
      IdExemplar = idExemplar;
      IdLocador = idLocador;
      DataDevolucao = dataLoc.AddDays(15);
    }
    public override string ToString(){
      return $"Id Locação: {this.Id}\nData de Locacao: {this.DataLocacao}\nId Exemplar: {this.IdExemplar}\nId Locador: {this.IdLocador}\nData de Devolucao: {this.DataDevolucao}";
    }
    public int CompareTo(object obj){
      Locacao l1 = (Locacao) obj;
      return this.DataDevolucao.CompareTo(l1.DataDevolucao);
    }
  }
}
