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


            Reclamacao r1, r2, r3, r4, r5;
            
            r1= new Reclamacao{Titulo="Calçada esburacada", Categoria=c2};
            r2=new Reclamacao{Titulo="Semáforo queimado", Categoria=c3};
            r3=new Reclamacao{Titulo="Faixa segurança apagada", Categoria=c3};
            r4=new Reclamacao{Titulo="Casa com pintura feia", Categoria=c1};
            r5=new Reclamacao{Titulo="Jardim mal conservado", Categoria=c1};
            
            List<Reclamacao> reclamacoes=new List<Reclamacao>(){r1, r2, r3, r4, r5};

            reclamacoes.ForEach(s => context.Reclamacaos.Add(s));
            context.SaveChanges();

            var comentarios = new List<Comentario>()
            {
                new Comentario{Descricao="Já cai lá uma vez", Usuario="Anonimo", Reclamacao=r1},
                new Comentario{Descricao="O transito vira uma confusão", Usuario="Anonimo", Reclamacao=r2},
                new Comentario{Descricao="Os carros passam como se não houvesse faixa", Usuario="Anonimo", Reclamacao=r3},
                new Comentario{Descricao="Meu deus, que casa mais feia!", Usuario="Anonimo", Reclamacao=r4},
                new Comentario{Descricao="As plantas estão todas mortas", Usuario="Anonimo", Reclamacao=r5},
            };

            comentarios.ForEach(s => context.Comentarios.Add(s));
            context.SaveChanges();

        }
    }
}