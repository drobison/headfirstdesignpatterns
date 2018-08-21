using Chapter02.Subject;
using System;

namespace Chapter02.Observers
{
    public class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        public CurrentConditionsDisplay(ISubject subject)
        {
            subject.RegisterObserver(this);
        }

        private WeatherMeasurements _currentWeatherMeasurements;
        public void Display()
        {
            if (_currentWeatherMeasurements == null)
            {
                Console.WriteLine("No data");
                return;
            }
            Console.WriteLine($"Current conditions: {string.Format("{0:f1}", _currentWeatherMeasurements.Temperature.Value)} {_currentWeatherMeasurements.Temperature.TemperatureType.ToString()} and {_currentWeatherMeasurements.Humidty}% humidity");
        }

        public void Update(WeatherMeasurements measurment)
        {
            _currentWeatherMeasurements = measurment;
            Display();
        }
    }
}
