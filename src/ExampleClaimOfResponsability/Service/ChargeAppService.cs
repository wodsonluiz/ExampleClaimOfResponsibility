using ExampleClaimOfResponsability.Entities;
using ExampleClaimOfResponsability.Handler;
using ExampleClaimOfResponsability.Interfaces;

namespace ExampleClaimOfResponsability.Service
{
    public class ChargeAppService : IChargeAppService
    {
        public Charge AlteraMeioPagamento(string payMethod)
        {
            var charge = new Charge()
            {
                Id = 1,
                ExternalId = "ch_123124124",
                CreditCard = new CreditCardTransaction()
                {
                    Id = 1, 
                    Amout = 10m
                }
            };

            var validator = new SetupValidateChargeHandler();

            var resultValidation = validator.Valid(payMethod, charge);

            return charge;
        }
    }
}