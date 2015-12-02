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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ReclamePOAContext _db = new ReclamePOAContext();
                TextBoxDescricao.Text = PreviousPage.Titulo;
                //GridView1.DataSource = lista com todos os comentarios
                GridView1.DataBind();
                
            }
        }

        protected void ButtonComentario_Click(object sender, EventArgs e)
        {
            int codigo = Int32.Parse(PreviousPage.ID + "" + ++contador);
            
            Comentario c = new Comentario{
                Descricao=txtBoxComentario.Text,
                ReclamacaoID=codigo
            };
            //Adicionar comentario na tabela
            Response.Redirect("Comentarios.aspx");
        }
    }
}