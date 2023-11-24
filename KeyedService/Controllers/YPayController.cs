using KeyedService.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace KeyedService.Controllers;

[ApiController]
[Route("[controller]")]
public class YPayController([FromKeyedServices("YPay")] IPaymentSystem paymentSystem) : ControllerBase
{
    [HttpGet]
    public string Pay() => paymentSystem.Pay();
}