using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Order:BaseEntity, IOrder
    {
        public int CompanyId { get; set; }
        public int ProductId { get; set; }
        public string? CustomerName { get; set; }
        public DateTime OrderDate { get; set; }

        public Company? Company { get; set; }
        public Product? Product { get; set; }
    }
}
