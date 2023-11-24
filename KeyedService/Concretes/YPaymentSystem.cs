using KeyedService.Abstracts;

namespace KeyedService.Concretes;

public class YPaymentSystem: IPaymentSystem
{
    public string Pay() => "Y Payment Successfully";
}