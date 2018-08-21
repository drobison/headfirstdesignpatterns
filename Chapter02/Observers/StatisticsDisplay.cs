using Chapter02.Subject;
using System;

namespace Chapter02.Observers
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private double _maxTemperatureOccurance = 0.0d;
        private double _minTemperatureOccurance = 200;
        private double _temperatureSum = 0.0d;
        private double _numberOfReadings;

        public StatisticsDisplay(ISubject subject)
        {
            subject.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (_temperatureSum / _numberOfReadings) +
                "/" + _maxTemperatureOccurance + "/" + _minTemperatureOccurance);
        }

        public void Update(WeatherMeasurements measurment)
        {
            _numberOfReadings++;

            // If we add celcius support we can do conversion here.  For now assume farenheit
            double normalizedTemperatureValue = measurment.Temperature.Value;

            _temperatureSum += normalizedTemperatureValue;


            if (normalizedTemperatureValue > _maxTemperatureOccurance)
            {
                _maxTemperatureOccurance = normalizedTemperatureValue;
            }
            if(normalizedTemperatureValue < _minTemperatureOccurance)
            {
                _minTemperatureOccurance = normalizedTemperatureValue;
            }

            Display();
        }
    }
}
