using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Textil.Web.Models
{
    public class Anexo
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public byte[] Base64 { get; set; }
    }
}