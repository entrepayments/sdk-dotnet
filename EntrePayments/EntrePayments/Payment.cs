namespace EntrePayments;

using Request;

public class Payment
{
    public const string AuthorizationWithout3Ds = "A";
    public const string AuthorizationWith3Ds = "1";
    public const string PreAuthorization = "1";
    public const string AuthorizationConfirmation = "2";
    public const string Cancelment = "3";
    public const string PreAuthorizationCancelment = "9";

    public Payment(Order order, Card? card = null, string softDescriptor = "", int installments = 1)
    {
        Order = order;
        SoftDescriptor = softDescriptor;
        Installments = installments;

        if (card != null) Card = card;
    }

    public Order Order { get; set; }
    public Card? Card { get; set; }
    public IEnvironment? Environment { get; set; }
    public string? SoftDescriptor { get; set; }
    public int Installments { get; set; } = 1;
    public bool SecurePayment { get; set; } = false;
    public string? AuthenticationUrl { get; set; }
    public string? AuthorizationCode { get; set; }
    public string? Language { get; set; }
    public string? Nsu { get; set; }
    public string? ProcessedPayMethod { get; set; }
    public string? Response { get; set; }
    public string? ResponseInt { get; set; }
    public string? PaRequest { get; set; }
    public string? Md { get; set; }
    public string? MerchantData { get; set; }
    public string? State { get; set; }
    public string? TransactionType { get; set; }

    public Order getOrder()
    {
        return Order;
    }
}