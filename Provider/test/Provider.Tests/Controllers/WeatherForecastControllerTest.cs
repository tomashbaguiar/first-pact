using Provider.Controllers;

namespace Provider.Tests.Controllers;

public class WeatherForecastControllerTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(5)]
    [InlineData(15)]
    public void Get_WhenDayIsN_ReturnsNForecasts(int days)
    {
        var sut = new WeatherForecastController();

        WeatherForecast[] forecast = sut.Get(days);

        forecast.Should().NotBeEmpty()
            .And.HaveCount(days);
    }
}
