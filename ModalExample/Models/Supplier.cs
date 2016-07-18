using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModalExample.Models
{
    public class Supplier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }        
        public virtual IList<Product> Products { get; set; }

        public Supplier()
        {
            Id = Guid.NewGuid();            
        }
    }
}