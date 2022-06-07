namespace EntrePayments;

using Request;

public class EntrePayments
{
    /**
     * The SDK Version
     */
    private const string Version = "1.0.0";

    private readonly IEnvironment _environment;

    public EntrePayments(IEnvironment environment)
    {
        _environment = environment;
    }

    public static EntrePayments Create(Merchant merchant, bool production = true)
    {
        return null;
    }

    public IEnvironment GetEnvironment()
    {
        return _environment;
    }

    public Payment Authorize(Payment payment, bool capture = true, bool tokenize = false)
    {
        return _environment.Authorize(payment, capture, false, tokenize);
    }

    public Payment Consult(Payment payment, string? transactionType)
    {
        transactionType ??= "1";

        return _environment.Consult(payment, transactionType);
    }

    public Payment ZeroDolar(Payment payment)
    {
        var amount = payment.getOrder().Amount;

        payment.getOrder().Amount = 0;

        var authorized = Authorize(payment);

        payment.getOrder().Amount = amount;

        return authorized;
    }

    public Payment Capture(Payment payment)
    {
        return _environment.Capture(payment);
    }


    public Payment Cancel(Payment payment)
    {
        return _environment.Cancel(payment, false);
    }

    public Payment VoidPayment(Payment payment)
    {
        return _environment.Cancel(payment, true);
    }
}