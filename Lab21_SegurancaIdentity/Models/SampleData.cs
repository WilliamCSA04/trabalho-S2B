// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ReclamaPoaS2B.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<ReclamePOAContext>
    {
        protected override void Seed(ReclamePOAContext context)
        {

            Categoria c1, c2, c3;
            c1 = new Categoria
            {
               
                Nome = "Limpeza",
                Descricao = "Problemas relacionados a limpeza urbana"
            };
            c2 = new Categoria
            {
                
                Nome = "Calçadas",
                Descricao = "Má conservação de calçadas"
            };
            c3 = new Categoria
            {
                
                Nome = "Trânsito",
                Descricao = "Problemas com transito e mobilidade urbana"
            };


            List<Categoria> categorias = new List<Categoria>() { c1, c2, c3 };


            categorias.ForEach(s => context.Categorias.Add(s));
            context.SaveChanges();


            var reclamacoes = new List<Reclamacao>()
            {
                new Reclamacao{Titulo="Calçada esburacada", Categoria=c2},
                new Reclamacao{Titulo="Semáforo queimado", Categoria=c3},
                new Reclamacao{Titulo="Faixa segurança apagada", Categoria=c3},
                new Reclamacao{Titulo="Casa com pintura feia", Categoria=c1},
                new Reclamacao{Titulo="Jardim mal conservado", Categoria=c1}
            };


            reclamacoes.ForEach(s => context.Reclamacaos.Add(s));
            context.SaveChanges();



        }
    }
}