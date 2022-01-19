namespace ExampleClaimOfResponsability.Entities
{
    public class Charge
    {
        public int Id { get; set; }
        public string? ExternalId { get; set; }

        public string MeioPagamento { get; set; }
        public CreditCardTransaction? CreditCard { get; set; }

        public PixTransaction? Pix { get; set; }

        public DebitCardTransaction? DebitCard { get; set; }
    }
}