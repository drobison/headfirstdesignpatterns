using Chapter02.Subject;

namespace Chapter02.Observers
{
    public interface IObserver
    {
        void Update(WeatherMeasurements measurment);
    }
}