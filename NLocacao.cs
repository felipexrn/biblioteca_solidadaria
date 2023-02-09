using System;
using Modelo;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
namespace Negocio {
  public class NLocacao {
    private static List<Locacao> locacoes; 
    public static void LocacaoInserir(Locacao l) {
      LocacaoAbrirArquivo();
      int id;
      if (locacoes.Count == 0) id = 1;
      else {
        id = locacoes.Max(x => x.IdLocacao);
        id++;
      }
      l.IdLocacao = id;
      
      Exemplar exemplar = NExemplar.ExemplarListar(l.IdExemplar);
      if (exemplar.Alugado == "Não") {
        if (NExemplar.ExemplarExiste(exemplar.IdExemplar)) {
          exemplar.Alugado = "Sim";
          NExemplar.ExemplarAtualizar(exemplar);
          locacoes.Add(l);
        } else throw new ArgumentException("id inválido");
      } else throw new ArgumentException("Este exemplar está indisponível.");
      LocacaoSalvarArquivo();
    }
    public static List<Locacao> LocacaoListar() {
      LocacaoAbrirArquivo();
      return locacoes;
    }
    public static Locacao LocacaoListar(int id) {
      LocacaoAbrirArquivo();
      locacoes.Sort();
      return locacoes.Where(x => x.IdLocacao == id).SingleOrDefault();
    }
    public static void LocacaoAtualizar(Locacao l) {
      LocacaoAbrirArquivo();
      Locacao obj = LocacaoListar(l.IdLocacao);
      if (obj == null) 
        throw new ArgumentOutOfRangeException("id inválido");
      else {
        obj.DataLocacao = l.DataLocacao;
        obj.IdExemplar = l.IdExemplar;
        obj.IdLocador = l.IdLocador;
        obj.DataDevolucao = l.DataDevolucao;
        LocacaoSalvarArquivo();
      }
    }
    public static void LocacaoExcluir(Locacao l) {
      LocacaoAbrirArquivo();
      Locacao obj = LocacaoListar(l.IdLocacao);
      if (obj == null) 
        throw new ArgumentOutOfRangeException("id inválido");
      else {
        locacoes.Remove(obj);
      }
      LocacaoSalvarArquivo();
    }
    public static void LocacaoAbrirArquivo() {
      XmlSerializer xml = new XmlSerializer(typeof(List<Locacao>));
      StreamReader stream = null;
      try {
        stream = new StreamReader("./locacoes.xml");
        locacoes = (List<Locacao>) xml.Deserialize(stream);
      }
      catch (FileNotFoundException) {
        locacoes = new List<Locacao>();
      }
      if (stream != null) stream.Close();
    }
    public static void LocacaoSalvarArquivo() {
      XmlSerializer xml = new XmlSerializer(typeof(List<Locacao>));
      StreamWriter stream = new StreamWriter("./locacoes.xml", false);
      xml.Serialize(stream, locacoes);
      stream.Close();
    }
    public static void LocacaoOrdenarDataDevCres() {
      LocacaoAbrirArquivo();
      locacoes.Sort();
    }
    public static void LocacaoOrdenarDataDevDecres() {
      LocacaoAbrirArquivo();
      locacoes.Reverse();
    }
    public static int LocacaoContarLocadorAlugado(int idLocador) {
      List<Locacao> locacoesLocador = new List<Locacao>();
      locacoesLocador = locacoes;
      List<Exemplar> exemplaresLocador = new List<Exemplar>();
      exemplaresLocador = NExemplar.ExemplarListar();
      /*
      Object query = 
        from loc in locacoesLocador
        join exe in exemplaresLocador
        on loc.IdExemplar equals exe.IdExemplar
        select new {
          locador = loc.IdLocador,
          alugado = exe.Alugado
        };
      
      int qtd = 0;
      Console.WriteLine(query);*/
      return qtd;
    }
  }
}