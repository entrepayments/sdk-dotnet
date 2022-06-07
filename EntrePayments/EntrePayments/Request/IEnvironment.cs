namespace EntrePayments.Request;

/**
 * Defines an Environment to be used to request the API.
 */
public interface IEnvironment
{
    bool IsProduction();

    public Merchant GetMerchant();

    public string GetUserAgent();

    public Payment Authorize(
        Payment payment,
        bool? capture,
        bool? recurring,
        bool? tokenize
    );

    public Payment Consult(Payment payment, string transactionType);

    public Payment Capture(Payment payment);

    public Payment Cancel(Payment payment, bool preAuthorization);
}