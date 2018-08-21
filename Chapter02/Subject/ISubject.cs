using Chapter02.Observers;

namespace Chapter02.Subject
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver();
    }
}
