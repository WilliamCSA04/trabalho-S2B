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
            if (GridView1.SelectedIndex != -1 /*&& ver se a reclamação escolhida foi criada pelo usuario*/)
            {
                Server.Transfer("~/EditarReclamacao.aspx");
            }
        }

        protected void cmdFiltrar_Click(object sender, EventArgs e)
        {
            int i;
            try{
                i = Int32.Parse(RadioButtonList2.SelectedValue);
            }
            catch (FormatException)
            {
                i=0;
            }

            if (i == 0)
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
                            //GridView1.DataSource = Acessar data das reclamações dentro do range
                            GridView1.DataBind();
                        }
                        else Erro1();
                    }
                    catch (FormatException)
                    {
                        Erro2();
                    }
                }
                else
                {
                    DefaultGridView();
                }
            }
            else
            {
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
                                //GridView1.DataSource = Acessar data das reclamações dentro do range e com a categoria selecionada
                                GridView1.DataBind();
                            }
                            else Erro1();
                            
                        }
                        catch (FormatException)
                        {
                            Erro2();
                        }
                    }
                    else
                    {
                        //GridView1.DataSource = Acessar data das reclamações com a categoria selecionada
                        GridView1.DataBind();
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
                                //GridView1.DataSource = Acessar data das reclamações dentro do range e com a categoria selecionada
                                GridView1.DataBind();
                            }
                            else Erro1();
                        }
                        catch (FormatException)
                        {
                            Erro2();
                        }
                    }
                    else
                    {
                        //GridView1.DataSource = Acessar data das reclamações com o bairro selecionado
                        GridView1.DataBind();
                    }
                }
            }
        }

        private void Erro1()
        {
            TextBox1.Text = "Data final superior a inicial";
            TextBox2.Text = "Data final superior a inicial";
            DefaultGridView();
        }

        private void Erro2()
        {
            TextBox1.Text = "Data invalida";
            TextBox2.Text = "Data invalida";
            DefaultGridView();
        }

        private void DefaultGridView()
        {
            GridView1.DataSource = Repositorio.getReclamacoes();
            GridView1.DataBind();
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