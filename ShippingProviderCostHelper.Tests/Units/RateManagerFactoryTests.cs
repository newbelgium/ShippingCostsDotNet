using Xunit;

namespace ShippingCostsDotNet.Tests.Units
{
    public class RateManagerFactoryTests
    {
        [Fact]
        public void InstantiatesRateManagerUsingReflection()
        {
            var rateManager = RateManagerFactory.Build();

            Assert.NotNull(rateManager);

            //Todo: Needs better assertion
        }
    }
}
