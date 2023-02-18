using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class OrderManager:IOrderService
    {
        private readonly IOrderDal _order;

        public OrderManager(IOrderDal order)
        {
            _order = order;
        }

        public List<Order> GetList()
        {
           return _order.List();
        }

        public List<Order> GetList(int id)
        {
            return _order.List(x=>x.Id == id);
        }

        public Order? GetById(int id)
        {
            return _order.GetById(x => x.Id == id);
        }

        public void Add(Order entity)
        {
            _order.Add(entity);
        }

        public void Update(Order entity)
        {
           _order.Delete(entity);
        }

        public void Delete(Order entity)
        {
            _order.Delete(entity);
        }
    }
}
