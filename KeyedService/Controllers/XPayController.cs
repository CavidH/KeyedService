using KeyedService.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace KeyedService.Controllers;

[ApiController]
[Route("[controller]")]
public class XPayController([FromKeyedServices("XPay")] IPaymentSystem paymentSystem) : ControllerBase
{
    [HttpGet]
    public string Pay() => paymentSystem.Pay();
}