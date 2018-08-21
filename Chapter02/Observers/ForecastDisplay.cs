using System;
using Chapter02.Subject;

namespace Chapter02.Observers
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private double currentPressure = 29.92d;
        private double lastPressure;

        public ForecastDisplay(ISubject subject)
        {
            subject.RegisterObserver(this);
        }

        public void Update(WeatherMeasurements measurment)
        {
            lastPressure = currentPressure;
            currentPressure = measurment.Pressure;
            Display();
        }

        public void Display()
        {
            Console.Write("Forecast: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }

        }
    }
}
