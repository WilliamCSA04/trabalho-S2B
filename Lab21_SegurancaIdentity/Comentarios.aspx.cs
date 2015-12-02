using ReclamaPoaS2B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReclamaPoaS2B
{
    public partial class Comentarios : System.Web.UI.Page
    {
        private static int contador=0;
        private static string titulo;
        private static int cod;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
                if (PreviousPage != null)
                {
                    ReclamePOAContext _db = new ReclamePOAContext();
                    TextBoxDescricao.Text = PreviousPage.Titulo;
                    titulo = TextBoxDescricao.Text;
                    cod = PreviousPage.ID;
                    GridView1.DataSource = Repositorio.getComentariosById(cod);
                    GridView1.DataBind();
                }
                else
                {
                    TextBoxDescricao.Text = titulo;
                    GridView1.DataSource = Repositorio.getComentariosById(cod);
                    GridView1.DataBind();
                }
                
                
            }
        }

        protected void ButtonComentario_Click(object sender, EventArgs e)
        {
            //int codigo = Int32.Parse(cod + "" + ++contador);
            Comentario c = new Comentario{
                Descricao=txtBoxComentario.Text,
                ReclamacaoID=cod
            };
            Repositorio.insereComentario(c);
        }
    }
}