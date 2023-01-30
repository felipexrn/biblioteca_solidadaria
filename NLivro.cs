using System;
using Modelo;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
namespace Negocio {
  public class NLivro {
    private static List<Livro> livros;
    public static void LivroInserir(Livro l) {
      LivroAbrirArquivo();
      int id;
      if (livros.Count == 0) id = 1;
      else {
        id = livros.Max(x => x.Id);
        id++;
      }
      l.Id = id;
      livros.Add(l);
      LivroSalvarArquivo();
    }
    public static List<Livro> LivroListar() {
      LivroAbrirArquivo();
      return livros;
    }
    public static Livro LivroListar(int id) {
      LivroAbrirArquivo();
      return livros.Where(x => x.Id == id).SingleOrDefault();
    }
    public static void LivroAtualizar(Livro l) {
      LivroAbrirArquivo();
      Livro obj = LivroListar(l.Id);
      if (obj == null) 
        throw new ArgumentOutOfRangeException("id inválido");
      else {
        obj.Titulo = l.Titulo;
        obj.Volume = l.Volume;
        obj.Edicao = l.Edicao;
        obj.Autor = l.Autor;
        obj.Descricao = l.Descricao;
        obj.Isbn = l.Isbn;
        LivroSalvarArquivo();
      }
    }
    public static void LivroExcluir(int id) {
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
      XmlSerializer xml = new XmlSerializer(typeof(List<Livro>));
      StreamWriter stream = new StreamWriter("./livros.xml", false);
      xml.Serialize(stream, livros);
      stream.Close();
    }
  }
}
