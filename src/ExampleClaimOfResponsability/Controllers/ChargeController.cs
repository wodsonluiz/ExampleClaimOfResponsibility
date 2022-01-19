using ExampleClaimOfResponsability.Entities;
using ExampleClaimOfResponsability.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ExampleClaimOfResponsability.Controllers
{
    [ApiController]
[   Route("[controller]")]
    public class ChargeController : ControllerBase
    {
        private readonly IChargeAppService service;

        public ChargeController(IChargeAppService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(this.service));
        }

        [HttpPatch]
        [Route("altera-meio-pagamento/{PayMethod}")]
        public ActionResult<Charge> AlteraMeioPagamento(string payMethod)
        {
            return this.service.AlteraMeioPagamento(payMethod);
        }
    }
}