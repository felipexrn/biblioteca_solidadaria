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
      Exemplar exemplar = new Exemplar {Alugado = "Não", IdLivro = l.Id};
      NExemplar.ExemplarInserir(exemplar);
      LivroSalvarArquivo();
    }
    public static List<Livro> LivroListar() {
      LivroAbrirArquivo();
      livros.Sort();
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
    public static void LivroExcluir(Livro l) {
      LivroAbrirArquivo();
      Livro obj = LivroListar(l.Id);
      if (obj == null) 
        throw new ArgumentOutOfRangeException("id inválido");
      else {
        if (NExemplar.ExemplarContarIdLivro(obj.Id) == 1) {
          livros.Remove(obj);
        } else {
          throw new ArgumentOutOfRangeException("Existe mais de 1 exemplar deste livro.");
        }
        LivroSalvarArquivo();
      }
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
    public static List<Livro> LivroPesquisarTitulo(string titulo) {
      LivroAbrirArquivo();
      List<Livro> pesquisa = new List<Livro>();
      pesquisa = livros.Where(x => x.Titulo.Contains(titulo) == true).ToList();
      pesquisa.Sort();
      return pesquisa;
    }
    public static List<Livro> LivroPesquisarAutor(string autor) {
      LivroAbrirArquivo();
      List<Livro> pesquisa = new List<Livro>();
      CompAutor ca = new CompAutor();
      pesquisa = livros.Where(x => x.Autor.Contains(autor) == true).ToList();
      //pesquisa.Sort(ca);
      return pesquisa;
    }
    public static bool LivroExiste(int idLivro) {
      LivroAbrirArquivo();
      return livros.Exists(x => x.Id == idLivro);
    }
  }
}
