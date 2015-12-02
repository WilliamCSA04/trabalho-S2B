using ReclamaPoaS2B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReclamaPoaS2B
{
    public partial class Reclamacoes : System.Web.UI.Page
    {
        public int ID { get; set; }
        public String Titulo { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                ReclamePOAContext _db = new ReclamePOAContext();

                ddlCategoria.DataSource = _db.Categorias.ToList();
                ddlCategoria.DataTextField = "Nome";
                ddlCategoria.DataValueField = "CategoriaId";
                ddlCategoria.DataBind();
                GridView1.DataSource = _db.Reclamacaos.ToList();
                GridView1.AutoGenerateSelectButton=true;
                GridView1.DataBind();
            }
        }

        protected void cmdInserir_Click(object sender, EventArgs e)
        {
            int codCategoria = int.Parse(ddlCategoria.SelectedValue);

                 Reclamacao nova = new Reclamacao
                 {
                     Titulo = textTitulo.Text,
                     CategoriaId = codCategoria

                 };
                 Repositorio.insereReclamacao(nova);
             Response.Redirect("Reclamacoes.aspx");
            
        }

        protected void cmdComentario_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedIndex != -1)
            {
                GridViewRow gvr = GridView1.Rows[GridView1.SelectedIndex];
                ID = Int32.Parse(gvr.Cells[1].Text);
                Titulo = gvr.Cells[2].Text;
                Server.Transfer("~/Comentarios.aspx");
            }
        }

        protected void cmdEditar_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedIndex != -1)
            {
                //TODO: Terminar
                Server.Transfer("~/EditarReclamacao.aspx");
            }
        }

        protected void cmdFiltrar_Click(object sender, EventArgs e)
        {

        }

    }
}