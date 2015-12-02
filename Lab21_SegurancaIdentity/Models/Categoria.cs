using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReclamaPoaS2B.Models
{
    public class Categoria
    {
      
        public int CategoriaId { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
       
       
        public virtual List<Reclamacao> Reclamacoes { get; set; }


        public override string ToString()
        {
            return String.Format("{0}: {1} - {2}", 
                                 CategoriaId, Nome, Descricao);
        }
    }
}