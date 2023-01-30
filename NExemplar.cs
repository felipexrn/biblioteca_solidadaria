using System;
using Modelo;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
namespace Negocio {
  public class NExemplar {
    private static List<Exemplar> exemplares;
    public static void ExemplarInserir(int idLivro, bool a) {
      /*implementar*/
    }
    public static void ExemplarAtualizar(int idExemplar, int idLivro, bool a) {
      /*implementar*/
    }
    public static void ExemplarExcluir(int idExemplar) {
      /*implementar*/
    }
    public static List<Exemplar> ExemplarListar() {
      return exemplares;
      /*implementar*/
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
  }
}
