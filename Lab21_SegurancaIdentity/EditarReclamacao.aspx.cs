using ReclamaPoaS2B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReclamaPoaS2B
{
    public partial class EditarReclamacao : System.Web.UI.Page
    {
        public static int id;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                id = PreviousPage.ID; //Usar para pegar os dados atraves desse id
                //TextBairro= pegar do banco o bairro
                //TextEndereco= pegar do banco o endereço
                //TextTitulo= pegar do banco o titulo
                //TextDescricao= pegar do banco o descricao
                //TextData= pegar do banco o data
                ReclamePOAContext _db = new ReclamePOAContext();
                ddlCategoria.DataSource = _db.Categorias.ToList();
                ddlCategoria.DataTextField = "Nome";
                ddlCategoria.DataValueField = "CategoriaId";
                ddlCategoria.DataBind();
            }
        }

        protected void cmdEditar_Click(object sender, EventArgs e)
        {
            //Fazer um update com todos os dados alterados
            Response.Redirect("Reclamacoes.aspx");
        }
    }
}