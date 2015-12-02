using ReclamaPoaS2B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReclamaPoaS2B
{
    public partial class PaginaAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlCategorias.DataSource = Repositorio.getCategorias();
                ReclamePOAContext _db = new ReclamePOAContext();
                ddlCategorias.DataSource = _db.Categorias.ToList();

                ddlCategorias.DataBind();
            }
        }

        protected void cmdInserir_Click(object sender, EventArgs e)
        {
            Categoria nova = new Categoria
            {

                Nome = txtNome.Text,
                Descricao = txtDescricao.Text
            };

            ReclamePOAContext _db = new ReclamePOAContext();
            _db.Categorias.Add(nova);
            _db.SaveChanges();
            Response.Redirect("Categorias.aspx");
        }

        protected void Calcular1(object sender, EventArgs e)
        {

        }
        protected void Calcular2(object sender, EventArgs e)
        {

        }
        protected void Calcular3(object sender, EventArgs e)
        {

        }
        protected void Calcular4(object sender, EventArgs e)
        {

        }
    }
}