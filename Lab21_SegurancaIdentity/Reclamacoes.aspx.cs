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
                ddlReclamacoes.DataSource = Repositorio.getReclamacoes();
                ddlReclamacoes.DataBind();

                ddlCategoria.DataSource = Repositorio.getCategorias();
                ddlCategoria.DataTextField = "Nome";
                ddlCategoria.DataValueField = "CategoriaId";
                ddlCategoria.DataBind();
                GridView1.DataSource = Repositorio.getReclamacoes();
                GridView1.AutoGenerateSelectButton=true;
                GridView1.DataBind();
            }
        }

        protected void cmdInserir_Click(object sender, EventArgs e)
        {
            int codCategoria = int.Parse(ddlCategoria.SelectedValue);

                 Reclamacao nova = new Reclamacao
                 {
                     Titulo = txtTitulo.Text,
                     CategoriaId = codCategoria

                 };
                 Repositorio.insereReclamacao(nova);
             Response.Redirect("Reclamacoes.aspx");
            
        }

        protected void cmdComentario_Click(object sender, EventArgs e)
        {
            GridViewRow gvr = GridView1.SelectedRow;
            ID = Int32.Parse(gvr.Cells[0].Text);
            Titulo = gvr.Cells[1].Text;
            Response.Redirect("Comentarios.aspx");
        }

    }
}