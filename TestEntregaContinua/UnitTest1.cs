using WebAPIEntregaContinua.Controllers;

namespace TestEntregaContinua
{
    public class UnitTest1
    {
        [Fact]

        public void WeatherForecastController_ReturnsArray()

        {

            var controller = new WeatherForecastController(null);

            var result = controller.Get();

            Assert.NotNull(result);

        }

    }
}