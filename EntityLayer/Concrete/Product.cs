using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product:BaseEntity, IProduct
    {
        public int CompanyId { get; set; }
        public string? ProductName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public virtual Company? Company { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
