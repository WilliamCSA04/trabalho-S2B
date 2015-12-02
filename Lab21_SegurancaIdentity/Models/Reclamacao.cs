using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReclamaPoaS2B.Models
{
    public class Reclamacao
    {
        public int ReclamacaoId { get; set; }
        public String Titulo { get; set; }
        
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }


        public override string ToString()
        {
            return String.Format("{0}: ({1}) {2} ",
                                 ReclamacaoId, 
                                 Categoria.Nome,
                                 Titulo);
        }
    }
}