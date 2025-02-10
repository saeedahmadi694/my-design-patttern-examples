using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.sample.Patterns.ValueObject;

public class Money
{
    public decimal Amount { get; private set; }
    public string Currency { get; private set; }
    public Money(decimal amount, string currency)
    {
        if (amount < 0)
            throw new ArgumentException("Amount cannot be negative.");
        if (string.IsNullOrWhiteSpace(currency))
            throw new ArgumentException("Currency cannot be empty.");

        Amount = amount;
        Currency = currency;
    }

    public static bool operator ==(Money money1, Money money2)
    {
        return money1.Amount == money2.Amount && money1.Currency == money2.Currency;
    }

    public static bool operator !=(Money money1, Money money2)
    {
        return !(money1 == money2);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;
        var money = (Money)obj;
        return Amount == money.Amount && Currency == money.Currency;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Amount, Currency);
    }
}
