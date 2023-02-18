using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyOrderManagementDemoV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyManager _company;

        public CompanyController(CompanyManager company)
        {
            _company = company;
        }

        [HttpGet]
        public async Task<IActionResult> ListCompany()
        {
            var values = _company.GetList();
            return await Task.FromResult<IActionResult>(Ok(values));
        }


        [HttpPost]
        public async Task<IActionResult> AddCompany([FromBody] Company company)
        {
            _company.Add(company);
            return await Task.FromResult(Ok("Şirket başarılı bir şekilde eklendi."));
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id,Company company)
        {
            var value = _company.GetById(id);
            if (value != null)
            {
                value.OrderAllowStartTime = company.OrderAllowStartTime;
                value.OrderAllowFinishTime = company.OrderAllowFinishTime;
                value.Status = company.Status;
               _company.Update(value);
                return await Task.FromResult(Ok("Başarıyla Güncellendi"));
            }
            else
            {
                return await Task.FromResult(NotFound("Girilen id ye ait şirket bulunamadı"));
            }
        }
    }
}
