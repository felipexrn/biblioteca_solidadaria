using System;
using Modelo;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
namespace Negocio {
  public class NLocador {
    private static List<Locador> locadores;
    public static void LocadorInserir(Locador l) {
      LocadorAbrirArquivo();
      int id;
      if (locadores.Count == 0) id = 1;
      else {
        id = locadores.Max(x => x.IdLocador);
        id++;
      }
      l.IdLocador = id;
      locadores.Add(l);
      LocadorSalvarArquivo();
    }
    public static List<Locador> LocadorListar() {
      LocadorAbrirArquivo();
      locadores.Sort();
      return locadores;
    }
    public static Locador LocadorListar(int id) {
      LocadorAbrirArquivo();
      return locadores.Where(x => x.IdLocador == id).SingleOrDefault();
    }
    public static void LocadorAtualizar(Locador l) {
      LocadorAbrirArquivo();
      Locador obj = LocadorListar(l.IdLocador);
      if (obj == null) 
        throw new ArgumentOutOfRangeException("id inválido");
      else {
        obj.Nome = l.Nome;
        obj.Telefone = l.Telefone;
        LocadorSalvarArquivo();
      }
    }
    public static void LocadorExcluir(Locador l) {
      LocadorAbrirArquivo();
      Locador obj = LocadorListar(l.IdLocador);
      if (obj == null) 
        throw new ArgumentOutOfRangeException("id inválido");
      else {
        if (/*NLocacao.LocacaoContarLocadorAlugado(obj.IdLocador) == 0*/true) { // Resolver esse bug 
          locadores.Remove(obj);
        } else {
          throw new ArgumentException("Existem 1 ou mais exemplares alugados por este(a) locador(a).");
        }
        LocadorSalvarArquivo();
      }
    }
    public static void LocadorAbrirArquivo() {
      XmlSerializer xml = new XmlSerializer(typeof(List<Locador>));
      StreamReader stream = null;
      try {
        stream = new StreamReader("./locadores.xml");
        locadores = (List<Locador>) xml.Deserialize(stream);
      }
      catch (FileNotFoundException) {
        locadores = new List<Locador>();
      }
      if (stream != null) stream.Close();
    }
    public static void LocadorSalvarArquivo() {
      XmlSerializer xml = new XmlSerializer(typeof(List<Locador>));
      StreamWriter stream = new StreamWriter("./locadores.xml", false);
      xml.Serialize(stream, locadores);
      stream.Close();
    }
    public static List<Locador> LocadorPesquisar(string nome) {
      LocadorAbrirArquivo();
      List<Locador> pesquisa = new List<Locador>();
      pesquisa = locadores.Where(x => x.Nome.Contains(nome) == true).ToList();
      pesquisa.Sort();
      return pesquisa;
    }
  }
}
