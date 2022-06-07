namespace EntrePayments;

public class Card
{
    public const int CREDITCARD = 1;
    public const int DEBITCARD = 2;
    public const bool Use3Ds = true;
    public const int ThreeDSecureVersion1 = 1;
    public const int ThreeDSecureVersion2 = 2;

    public Card(
        int accountType,
        string pan,
        string expirationYear,
        string expirationMonth,
        string holderName,
        string cvv
    )
    {
        AccountType = accountType;
        Pan = pan;
        Expiration = expirationYear + expirationMonth;
        HolderName = holderName;
        Cvv = cvv;
    }

    public Card(
        int accountType,
        string identifier
    )
    {
        AccountType = accountType;
        Identifier = identifier;
    }

    public int AccountType { get; set; }
    public string? Pan { get; set; }
    public string? Expiration { get; set; }
    public string? HolderName { get; set; }
    public string? Cvv { get; set; }
    public bool ThreeDSecure { get; set; } = false;
    public int? ThreeDSecureVersion { get; set; } = ThreeDSecureVersion2;
    public int? CardBrand { get; set; }
    public int? CardCountry { get; set; }
    public string? Identifier { get; set; }

    public static Card CreditCard(
        string pan,
        string expirationYear,
        string expirationMonth,
        string holderName,
        string cvv
    )
    {
        return new Card(
            CREDITCARD,
            pan,
            expirationYear,
            expirationMonth,
            holderName,
            cvv
        );
    }

    public static Card DebitCard(
        string pan,
        string expirationYear,
        string expirationMonth,
        string holderName,
        string cvv,
        int? threeDSecureVersion
    )
    {
        threeDSecureVersion ??= ThreeDSecureVersion2;

        var card = new Card(
            DEBITCARD,
            pan,
            expirationYear,
            expirationMonth,
            holderName,
            cvv
        );

        card.ThreeDSecureVersion = threeDSecureVersion;

        return card;
    }

    public static Card Token(string identifier)
    {
        return new Card(
            CREDITCARD,
            identifier
        );
    }
}