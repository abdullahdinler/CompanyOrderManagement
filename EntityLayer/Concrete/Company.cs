using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Company:BaseEntity, ICompany
    {
        public string? CompanyName { get; set; }
        public bool Status { get; set; }
        public DateTime OrderAllowStartTime { get; set; }
        public DateTime OrderAllowFinishTime { get; set; }


        public ICollection<Product>? Products { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
