using System;
using Modelo;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
namespace Negocio {
  public class NExemplar {
    private static List<Exemplar> exemplares;
    public static void ExemplarInserir(Exemplar e) {
      ExemplarAbrirArquivo();
      int id;
      if (exemplares.Count == 0) id = 1;
      else {
        id = exemplares.Max(x => x.Id);
        id++;
      }
      e.Id = id;
      
      exemplares.Add(e);
      ExemplarSalvarArquivo();
    }
    public static List<Exemplar> ExemplarListar() {
      ExemplarAbrirArquivo();
      return exemplares;
    }
    public static Exemplar ExemplarListar(int id) {
      ExemplarAbrirArquivo();
      return exemplares.Where(x => x.Id == id).SingleOrDefault();
    }
    public static void ExemplarAtualizar(Exemplar e) {
      ExemplarAbrirArquivo();
      Exemplar obj = ExemplarListar(e.Id);
      if (obj == null) 
        throw new ArgumentOutOfRangeException("id inválido");
      else {
        obj.Alugado = e.Alugado;
        obj.IdLivro = e.IdLivro;
        ExemplarSalvarArquivo();
      }
    }
    public static void ExemplarExcluir(Exemplar e) {
      ExemplarAbrirArquivo();
      Exemplar obj = ExemplarListar(e.Id);
      if (obj == null) 
        throw new ArgumentOutOfRangeException("id inválido");
      else {
        exemplares.Remove(obj);
        ExemplarSalvarArquivo();
      }
    }
    public static void ExemplarAbrirArquivo() {
      XmlSerializer xml = new XmlSerializer(typeof(List<Exemplar>));
      StreamReader stream = null;
      try {
        stream = new StreamReader("./exemplares.xml");
        exemplares = (List<Exemplar>) xml.Deserialize(stream);
      }
      catch (FileNotFoundException) {
        exemplares = new List<Exemplar>();
      }
      if (stream != null) stream.Close();
    }
    public static void ExemplarSalvarArquivo() {
      XmlSerializer xml = new XmlSerializer(typeof(List<Exemplar>));
      StreamWriter stream = new StreamWriter("./exemplares.xml", false);
      xml.Serialize(stream, exemplares);
      stream.Close();
    }
    public static void ExemplarDevolver(Exemplar e) {
      ExemplarAbrirArquivo();
      Exemplar obj = ExemplarListar(e.Id);
      if (obj == null) 
        throw new ArgumentOutOfRangeException("id inválido");
      else {
        obj.Alugado = e.Alugado;
        ExemplarSalvarArquivo();
      }
    }
    public static int ExemplarContarIdLivro(int idLivro) {
      ExemplarAbrirArquivo();
      return exemplares.Count(x => x.IdLivro == idLivro);
    }
    public static int ExemplarContarAlugado(int idLivro) {
      ExemplarAbrirArquivo();
      return exemplares.Count(x => x.IdLivro == idLivro && x.Alugado == "Não");
    }
    public static int ExemplarContarAlugado(Exemplar l) {
      ExemplarAbrirArquivo();
      return exemplares.Count(x => x.Id == l.Id && x.Alugado == "Não");
    }
  }
}
