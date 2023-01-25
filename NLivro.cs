using System;
using Modelo;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
namespace Negocio {
  public class NLivro {
    private static List<Livro> livros;
    public static void LivroInserir(string t, string a, string d, string i) {
      /*implementar*/
    }
    public static void LivroAtualizar(int idLivro, string t, string a, string d, string i) {
      /*implementar*/
    }
    public static void LivroExcluir(int id) {
      /*implementar*/
    }
    public static List<Livro> LivroListar() {
      return livros;
      /*implementar*/
    }
    public static void LivroAbrirArquivo() {
      XmlSerializer xml = new XmlSerializer(typeof(List<Livro>));
      StreamReader stream = null;
      try {
        stream = new StreamReader("./livros.xml");
        livros = (List<Livro>) xml.Deserialize(stream);
      }
      catch (FileNotFoundException) {
        livros = new List<Livro>();
      }
      if (stream != null) stream.Close();
    }
    public static void LivroSalvarArquivo() {
      /*implementar*/
    }
  }
}
