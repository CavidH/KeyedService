using KeyedService.Abstracts;

namespace KeyedService.Concretes;

public class XPaymentSystem : IPaymentSystem
{
    public string Pay() => "X Payment Successfully";
}