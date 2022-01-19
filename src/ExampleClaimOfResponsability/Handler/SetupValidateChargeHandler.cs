using ExampleClaimOfResponsability.Entities;
using ExampleClaimOfResponsability.Handler.Service;

namespace ExampleClaimOfResponsability.Handler
{
    public class SetupValidateChargeHandler
    {
        public string Valid(string payMethod, Charge charge)
        {
            var creditCard = new CreditCardValid();
            var debitCard = new DebitCardValid();
            var pixValid = new PixValid();

            creditCard.SetSuccessor(debitCard);
            debitCard.SetSuccessor(pixValid);

            return creditCard.Valid(payMethod, charge);
        }
    }
}