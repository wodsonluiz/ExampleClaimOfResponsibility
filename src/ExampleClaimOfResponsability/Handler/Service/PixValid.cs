using ExampleClaimOfResponsability.Entities;

namespace ExampleClaimOfResponsability.Handler.Service
{
    public class PixValid : IValidateChargeHandler
    {
        public override string Valid(string payMethod, Charge charge)
        {
            if (payMethod == "pix" && charge.Pix == null)
            {
                return "Pix is required.";
            }

            return Successor.Valid(payMethod, charge);
        }
    }
}