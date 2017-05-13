using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TareaRegistros.Models;

namespace TareaRegistros.DAL
{
    public class FarmaciaDb : DbContext
    {
        public FarmaciaDb() : base("ConStr")
        {

        }
        public DbSet<Clientes> Cliente { get; set; }

    }
}