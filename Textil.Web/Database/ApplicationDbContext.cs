using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Textil.Web.Models;

namespace Textil.Web.Database
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Tecido> Tecidos { get; set; }

        public ApplicationDbContext()
            : base("Data Source=FERNANDO-PC; Initial Catalog=novo_banco; Integrated Security=True;") { }        

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}