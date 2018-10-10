using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using Textil.Web.Models;

namespace Textil.Web.Database
{
    public class Operacoes
    {
        private static readonly Operacoes instance = new Operacoes();

        private readonly ApplicationDbContext context;


        private Operacoes()
        {
            context = new ApplicationDbContext();

        }

        public static Operacoes Instance
        {
            get
            {
                return instance;
            }
        }

        public void Adicionar(Tecido model)
        {
                context.Tecidos.Add(model);
                context.SaveChanges();
        }

        public void Editar(Tecido from, Tecido to)
        {
            var result = context.Tecidos.Where(x => x.Codigo == from.Codigo).FirstOrDefault();

            context.Tecidos.Remove(result);

            context.Tecidos.Add(to);

            context.SaveChanges();
        }

        public void Remover(Tecido model)
        {
            var result = context.Tecidos.Where(x => x.Codigo == model.Codigo).FirstOrDefault();
            context.Tecidos.Remove(result);

            context.SaveChanges();
        }

        public Tecido Consultar(Tecido tecido)
        {

            context.Tecidos.Where(x => x.Codigo == tecido.Codigo )

            bool HasId = tecido.Codigo >= 0 ? true : false;

            bool HasNome = string.IsNullOrEmpty(tecido.Nome) ? true : false;

            bool HasCor = string.IsNullOrEmpty(tecido.Cor) ? true : false;

            bool HasCategoria = string.IsNullOrEmpty(tecido.Categoria) ? true : false;
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM Tecidoes");
            if (HasId || HasNome || HasCor || HasCategoria)
                sb.Append("WHERE ");
            if (!string.IsNullOrEmpty(tecido.Nome))
                sb.Append($"AND Nome = '{tecido.Nome}'");
            if (!string.IsNullOrEmpty(tecido.Cor))
                sb.Append($"Cor = '{tecido.Cor}'AND");
            if (!string.IsNullOrEmpty(tecido.Categoria))
                sb.Append($"Categoria = '{tecido.Categoria}'");

            
            return context.Tecidos.SqlQuery(sb.ToString()).FirstOrDefault();
            
        }

        public void SalvarAnexo(string path)
        {
            using(StreamReader stream = new StreamReader(path))
            {
                var a = stream.ReadToEnd();               
            }
        }
    }
}