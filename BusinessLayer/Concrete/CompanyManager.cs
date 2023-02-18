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
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _company;

        public CompanyManager(ICompanyDal company)
        {
            _company = company;
        }

        public List<Company> GetList()
        {
            return _company.List();
        }

        public List<Company> GetList(int id)
        {
            return _company.List(x => x.Id == id);
        }

        public Company? GetById(int id)
        {
            return _company.GetById(x => x.Id == id);
        }

        public void Add(Company entity)
        {
            _company.Add(entity);
        }

        public void Update(Company entity)
        {
            _company.Update(entity);
        }

        public void Delete(Company entity)
        {
            _company.Delete(entity);
        }
    }
}
