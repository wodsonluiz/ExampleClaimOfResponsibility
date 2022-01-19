using ExampleClaimOfResponsability.Entities;

namespace ExampleClaimOfResponsability.Handler.Service
{
    public class CreditCardValid : IValidateChargeHandler
    {
        public override string Valid(string payMethod, Charge charge)
        {
            if (payMethod == "credit_card" && charge.CreditCard == null)
            {
                return "Credit card is required.";
            }

            return Successor.Valid(payMethod, charge);
        }
    }
}