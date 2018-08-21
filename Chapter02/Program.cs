using Chapter02.Observers;
using Chapter02.Subject;

namespace Chapter02
{
    /// <summary>
    /// Observer Pattern
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var forecastDisplay = new ForecastDisplay(weatherData);
            var statisticsDisplay = new StatisticsDisplay(weatherData);
            var heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.MeasurmentsChanged(
                new WeatherMeasurements()
                {
                    Temperature = new Temperature()
                        {
                            TemperatureType = Temperature.TemperatureTypeEnum.Fahrenheit,
                            Value = 80
                        },
                    Humidty = 65.0,
                    Pressure = 30.4d
                }
            );

            weatherData.MeasurmentsChanged(
                new WeatherMeasurements()
                {
                    Temperature = new Temperature()
                    {
                        TemperatureType = Temperature.TemperatureTypeEnum.Fahrenheit,
                        Value = 82
                    },
                    Humidty = 70.0,
                    Pressure = 27.2d
                }
            );

            weatherData.MeasurmentsChanged(
                new WeatherMeasurements()
                {
                    Temperature = new Temperature()
                    {
                        TemperatureType = Temperature.TemperatureTypeEnum.Fahrenheit,
                        Value = 78
                    },
                    Humidty = 90.0,
                    Pressure = 29.2d
                }
            );
        }
    }    
}
