using System;
using System.Collections;
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
      dataDevolucao = dataLoc;
      dataDevolucao.AddDays(15); // insere automaticamente a data de devolução para 15 dias após a data de locação;
    }
    public Locacao (DateTime dataLoc, int idExemplar, int idLocador){
      DataLocacao = dataLoc;
      IdExemplar = idExemplar;
      IdLocador = idLocador;
    }
    public override string ToString(){
      return $"Id: {this.Id}\nData de Locacao: {this.DataLocacao}\nId Exemplar: {this.IdExemplar}\nId Locador: {this.IdLocador}\nData de Devolucao: {this.dataDevolucao}";
    }
    public int CompareTo(object obj){
      Locacao l1 = (Locacao) obj;
      return this.dataDevolucao.CompareTo(l1.dataDevolucao);
    }
    public class CompDataLoc : IComparer {
      public int Compare(object obj1, object obj2) {
        Locacao l1 = (Locacao) obj1;
        Locacao l2 = (Locacao) obj2;
        return l1.DataLocacao.CompareTo(l2.DataLocacao);
      }
    }
  }
}
