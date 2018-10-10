using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Textil.Web.Database;

namespace Textil.Web.Models
{
    public class Tecido
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Colecao { get; set; }

        public string Composicao { get; set; }

        public string Fornecedor { get; set; }

        public string Cor { get; set; }

        public string Categoria { get; set; }

        public string Acabamento { get; set; }

        public List<Anexo> Anexo { get; set; }

    }
}