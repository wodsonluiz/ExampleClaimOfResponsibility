using ExampleClaimOfResponsability.Entities;

namespace ExampleClaimOfResponsability.Handler.Service
{
    public class DebitCardValid : IValidateChargeHandler
    {
        public override string Valid(string payMethod, Charge charge)
        {
            if (payMethod == "debit_card" && charge.DebitCard == null)
            {
                return "Debit card is required.";
            }

            return Successor.Valid(payMethod, charge);
        }
    }
}