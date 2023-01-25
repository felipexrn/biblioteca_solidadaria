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
      /*implementar*/
    }
    public static void ExemplarSalvarArquivo() {
      /*implementar*/
    }
  }
}
