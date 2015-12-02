using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ReclamaPoaS2B.Models
{
    public class ReclamePOAContext : DbContext
    {
        public ReclamePOAContext()
            : base("Database1")
        {
        }
        public DbSet<Reclamacao> Reclamacaos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    
    }

}