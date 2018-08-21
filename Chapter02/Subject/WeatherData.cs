using Chapter02.Observers;
using System.Collections.Generic;

namespace Chapter02.Subject
{
    public class WeatherData : ISubject
    {
        private List<IObserver> Observers;
        private WeatherMeasurements _measurements;
        public WeatherData()
        {
            Observers = new List<IObserver>();
        }
        public void NotifyObserver()
        {
            Observers.ForEach(o => o.Update(_measurements));
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public Temperature GetTemperature()
        {
            return _measurements.Temperature;
        }

        public double GetHumidty()
        {
            return _measurements.Humidty;
        }

        public double GetPressure()
        {
            return _measurements.Pressure;
        }

        public void MeasurmentsChanged(WeatherMeasurements measurments)
        {
            _measurements = measurments;
            NotifyObserver();
        }
    }
}
