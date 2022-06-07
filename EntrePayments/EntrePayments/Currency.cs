namespace EntrePayments;

public class Currency
{
    public const int Brl = 986;

    public static bool IsValid(int currency)
    {
        foreach (var testCurrency in AllCurrencies())
            if (testCurrency == currency)
                return true;

        return false;
    }

    public static IEnumerable<int> AllCurrencies()
    {
        return new[] { Brl };
    }
}