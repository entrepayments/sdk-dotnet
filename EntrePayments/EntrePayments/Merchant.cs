namespace EntrePayments;

public class Merchant
{
    public string MerchantCode { get; set; }
    public string MerchantKey { get; set; }
    public string Terminal { get; set; }

    public Merchant(string merchantKey, string merchantCode, string terminal)
    {
        MerchantKey = merchantKey;
        MerchantCode = merchantCode;
        Terminal = terminal;
    }
}