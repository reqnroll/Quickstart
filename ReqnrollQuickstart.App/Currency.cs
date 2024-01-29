namespace ReqnrollQuickstart.App;

// to be used later
public record Currency(string Symbol, decimal Value)
{
    public static Currency operator+(Currency a, Currency b)
    {
        if (a.Symbol != b.Symbol)
            throw new InvalidOperationException("Cannot add different currencies!");
        return new Currency(a.Symbol, a.Value + b.Value);
    }
    public static Currency operator *(Currency a, int b)
    {
        return new Currency(a.Symbol, a.Value * b);
    }
}
