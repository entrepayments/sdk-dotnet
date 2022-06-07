namespace EntrePayments;

public class Order
{
    public int Amount { get; set; }

    public int Currency
    {
        get { return Currency; }
        set
        {
            if (!global::EntrePayments.Currency.IsValid(value)) throw new Exception("Invalid currency");

            Currency = value;
        }
    }

    public string Description { get; set; }
    public string Number { get; set; }

    public Order(string number, int amount, int currency = global::EntrePayments.Currency.Brl, string description = "")
    {
        Number = number;
        Amount = amount;
        Currency = currency;
        Description = description;
    }
}