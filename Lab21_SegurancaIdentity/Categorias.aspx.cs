using ReclamaPoaS2B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReclamaPoaS2B
{
    public partial class Categorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               gvCategorias.DataSource = Repositorio.getCategorias();
                ReclamePOAContext _db = new ReclamePOAContext();
                gvCategorias.DataSource = _db.Categorias.ToList();
                
                gvCategorias.DataBind();
            }
        }

       
    }
}