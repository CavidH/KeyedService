using KeyedService.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace KeyedService.Controllers;

[ApiController]
[Route("[controller]")]
public class ZPayController([FromKeyedServices("ZPay")] IPaymentSystem paymentSystem) : ControllerBase
{
    [HttpGet]
    public string Pay() => paymentSystem.Pay();
}