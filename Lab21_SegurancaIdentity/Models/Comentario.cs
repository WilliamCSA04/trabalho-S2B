using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReclamaPoaS2B.Models
{

    

    public class Comentario
    {
        public int ComentarioId { get; set; }
        public String Descricao { get; set; }
        public String Usuario { get; set; }
        public int ReclamacaoID { get; set; }
        public virtual Reclamacao Reclamacao { get; set; }

        public override string ToString()
        {
            return String.Format("{0}: ({1}) ({2}) ",
                                 ComentarioId,
                                 Reclamacao.Titulo,
                                 Descricao);
        }

    }
}