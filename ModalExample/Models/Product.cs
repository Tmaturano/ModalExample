using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModalExample.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }

    }
}