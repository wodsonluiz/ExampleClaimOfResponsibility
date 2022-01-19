using ExampleClaimOfResponsability.Entities;

namespace ExampleClaimOfResponsability.Handler
{
    public abstract class IValidateChargeHandler
    {
        public abstract string Valid(string payMethod, Charge charge);

        protected IValidateChargeHandler? Successor;
        public void SetSuccessor(IValidateChargeHandler handler) => Successor = handler;
    }
}