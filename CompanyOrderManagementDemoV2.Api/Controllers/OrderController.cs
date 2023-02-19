using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyOrderManagementDemoV2.Api.Controllers
{
    [Route("api/[controller]/{entity}")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderManager _order;
        private readonly CompanyManager _company;
        public OrderController(OrderManager order, CompanyManager company)
        {
            _order = order;
            _company = company;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder([FromBody] Order entity)
        {
            var company = _company.GetById(entity.CompanyId);
           
            if (company!.Status == true)
            {
                var orderTime = company.OrderAllowStartTime <= entity.OrderDate &&
                                company.OrderAllowFinishTime <= entity.OrderDate;
                if (orderTime)
                {
                    _order.Add(entity);
                    return await Task.FromResult(Ok("Sipariş başarılı bir şekilde oloşturuldu."));
                }
                else
                {
                    return await Task.FromResult(BadRequest("Firmanız sipariş saatleri dışındadır"));
                }
            }
            else
            {
                return await Task.FromResult(BadRequest("Firmanız onaylı olmadığı için sipariş oluşturulamadı."));
            }

            
        }


    }
}
