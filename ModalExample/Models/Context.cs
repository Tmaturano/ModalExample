using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ModalExample.Models
{
    public class Context : DbContext
    {
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Product> Product { get; set; }

    }
}