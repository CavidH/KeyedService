using KeyedService.Abstracts;

namespace KeyedService.Concretes;

public class ZPaymentSystem : IPaymentSystem
{
    public string Pay() => "Z Payment Successfully";
}