using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;


namespace ReclamaPoaS2B
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
                LblMensagem.Text = "Usuario não autenticado";
            else
            {
                var currentUserId = User.Identity.GetUserId();

                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var currentUser = manager.FindById(currentUserId);


                LblMensagem.Text = currentUser.Nome + " - " + currentUser.Empresa;

            }


        }
    }
}