namespace ShippingProviderCostHelper
{
    public interface IRateAdjuster
    {
        Rate AdjustRate(Rate rate);
    }
}
