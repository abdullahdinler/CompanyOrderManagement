using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ProductManager:IProductService
    {
        private readonly IProductDal _product;

        public ProductManager(IProductDal product)
        {
            _product = product;
        }

        public List<Product> GetList()
        {
            return _product.List();
        }

        public List<Product> GetList(int id)
        {
            return _product.List(x=>x.Id == id);
        }

        public Product? GetById(int id)
        {
            return _product.GetById(x => x.Id == id);
        }

        public void Add(Product entity)
        {
            _product.Add(entity);
        }

        public void Update(Product entity)
        {
            _product.Update(entity);
        }

        public void Delete(Product entity)
        {
            _product.Delete(entity);
        }
    }
}
