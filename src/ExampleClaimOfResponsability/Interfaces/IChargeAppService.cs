using ExampleClaimOfResponsability.Entities;

namespace ExampleClaimOfResponsability.Interfaces
{
    public interface IChargeAppService
    {
        Charge AlteraMeioPagamento(string payMethod);
    }
}