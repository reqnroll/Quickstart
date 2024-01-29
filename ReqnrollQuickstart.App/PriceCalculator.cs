namespace ReqnrollQuickstart.App;

public class PriceCalculator
{
    // the item prices are hard coded for now
    private readonly Dictionary<string, decimal> _priceTable = new()
    {
        { "Electric guitar", 180.0m },
        { "Guitar pick", 1.5m }
    };

    public decimal CalculatePrice(Dictionary<string, int> basket)
    {
        //TODO: complete the price calculation once we defined more scenarios
        var item = basket.First();
        return _priceTable[item.Key];
    }
}
