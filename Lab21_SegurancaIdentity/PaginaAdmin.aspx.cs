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
            int i;
            try
            {
                i = Int32.Parse(RadioButtonList2.SelectedValue);
            }
            catch (FormatException)
            {
                i = 0;
            }
            
            if (i == 1)
            {
                string dataInicial = TextBox1.Text;
                string dataFinal = TextBox2.Text;
                if (dataInicial != "" && dataFinal != "")
                {
                    try
                    {
                        DateTime di = DateTime.Parse(dataInicial);
                        DateTime df = DateTime.Parse(dataFinal);
                        Boolean validador = ValidarData(di, df);
                        if (validador)
                        {
                            //TextBoxCalcular1.Text= Total de reclamações por Categoria
                        }
                        else Erro1();

                    }
                    catch (FormatException)
                    {
                        Erro2();
                    }
                }
                
            }
            else
            {
                string dataInicial = TextBox1.Text;
                string dataFinal = TextBox2.Text;
                if (dataInicial != "" && dataFinal != "")
                {
                    try
                    {
                        DateTime di = DateTime.Parse(dataInicial);
                        DateTime df = DateTime.Parse(dataFinal);
                        Boolean validador = ValidarData(di, df);
                        if (validador)
                        {
                            //TextBoxCalcular1.Text= Total de reclamações por Bairro
                        }
                        else Erro1();
                    }
                    catch (FormatException)
                    {
                        Erro2();
                    }
                }

            }
        }
        protected void Calcular2(object sender, EventArgs e)
        {
            int i;
            try
            {
                i = Int32.Parse(RadioButtonList2.SelectedValue);
            }
            catch (FormatException)
            {
                i = 0;
            }

            if (i == 1)
            {
                //TextBoxCalcular1.Text= Total de reclamações por Categoria
            }
            else
            {
                if (i == 2)
                {
                   //TextBoxCalcular1.Text= Total de reclamações por Bairro
                    
                }
                else
                {
                    string dataInicial = TextBox1.Text;
                    string dataFinal = TextBox2.Text;
                    if (dataInicial != "" && dataFinal != "")
                    {
                        try
                        {
                            DateTime di = DateTime.Parse(dataInicial);
                            DateTime df = DateTime.Parse(dataFinal);
                            Boolean validador = ValidarData(di, df);
                            if (validador)
                            {
                                //TextBoxCalcular1.Text= Total de reclamações no periodo
                            }
                            else Erro1();
                        }
                        catch (FormatException)
                        {
                            Erro2();
                        }
                    }
                }

            }
        }
        protected void Calcular3(object sender, EventArgs e)
        {
            //Acessar reclamacoes com o status de resolvido e fazer o percentual
        }
        protected void Calcular4(object sender, EventArgs e)
        {
            //Acessar reclamacoes com o status de resolvido por orgãos publicos e fazer o percentual
        }

        private void Erro1()
        {
            TextBox1.Text = "Data final superior a inicial";
            TextBox2.Text = "Data final superior a inicial";
        }

        private void Erro2()
        {
            TextBox1.Text = "Data invalida";
            TextBox2.Text = "Data invalida";
        }


        private Boolean ValidarData(DateTime di, DateTime df)
        {
            if (di.Year < df.Year)
            {
                return true;
            }
            else
            {
                if (di.Month < df.Month)
                {
                    return true;
                }
                else
                {
                    if (di.Day <= df.Day)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}