using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReclamaPoaS2B.Models
{
    public class Repositorio
    {
       
        public static List<Categoria> getCategorias()
        {
            ReclamePOAContext _db = new ReclamePOAContext();
            return _db.Categorias.ToList();
        }

        public static Categoria getCategoriaById(int cod)
        {
            ReclamePOAContext _db = new ReclamePOAContext();
            var result = (from c in _db.Categorias
                          where c.CategoriaId == cod
                          select c).FirstOrDefault();

            return result;

        }

        public static List<Reclamacao> getReclamacoes()
        {
            ReclamePOAContext _db = new ReclamePOAContext();
            return _db.Reclamacaos.ToList();
        }

        public static void insereCategoria(Categoria nova){
            ReclamePOAContext _db = new ReclamePOAContext();
            _db.Categorias.Add(nova);
            _db.SaveChanges();
        }

        public static void insereReclamacao(Reclamacao nova)
        {
            ReclamePOAContext _db = new ReclamePOAContext();
            _db.Reclamacaos.Add(nova);
            _db.SaveChanges();
        }
    }
}