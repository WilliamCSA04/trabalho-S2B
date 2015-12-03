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
                    GridView1.DataSource = Repositorio.getComentariosById(cod); //Verificar se metodo funciona
                    GridView1.DataBind();
                    if (Context.User.Identity.IsAuthenticated)
                    {
                        TextBoxNome.Text = Context.User.Identity.Name;
                        TextBoxNome.ReadOnly = true;
                    }
                    else TextBoxNome.ReadOnly = false;
                    
                }
                else
                {
                    if (Context.User.Identity.IsAuthenticated)
                    {
                        TextBoxNome.Text = Context.User.Identity.Name;
                        TextBoxNome.ReadOnly = true;
                    }
                    else TextBoxNome.ReadOnly = false;
                    TextBoxDescricao.Text = titulo;
                    GridView1.DataSource = Repositorio.getComentariosById(cod); //Verificar se metodo funciona
                    GridView1.DataBind();
                }
                
                
            }
        }

        protected void ButtonComentario_Click(object sender, EventArgs e)
        {
            Comentario c = new Comentario{
                Descricao=txtBoxComentario.Text,
                ReclamacaoID=cod
            };
            Repositorio.insereComentario(c);
        }


        protected void ButtonFechar_Click(object sender, EventArgs e)
        {
            //acessar o banco usando o cod para acessar a reclamação
            //alterar status da reclamação
        }
    }
}