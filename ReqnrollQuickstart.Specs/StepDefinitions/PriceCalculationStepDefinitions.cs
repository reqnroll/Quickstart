namespace ReqnrollQuickstart.Specs.StepDefinitions;

[Binding]
public class PriceCalculationStepDefinitions
{
    [Given("the client started shopping")]
    public void GivenTheClientStartedShopping()
    {
        throw new PendingStepException();
    }

    [Given("the client added {int} pcs of {string} to the basket")]
    public void GivenTheClientAddedPcsOfToTheBasket(int quantity, string product)
    {
        throw new PendingStepException();
    }

    [When("the basket is prepared")]
    public void WhenTheBasketIsPrepared()
    {
        throw new PendingStepException();
    }

    [Then("the basket price should be ${float}")]
    public void ThenTheBasketPriceShouldBe(decimal expectedPrice)
    {
        throw new PendingStepException();
    }
}
