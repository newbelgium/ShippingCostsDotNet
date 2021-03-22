namespace ShippingCostsDotNet
{
    public interface IRateAdjuster
    {
        Rate AdjustRate(Rate rate);
    }
}
