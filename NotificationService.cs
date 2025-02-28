using System;
using System.Collections.Generic;

public class NotificationService
{
    private List<INotificationObserver> _observers = new List<INotificationObserver>();

    public void Subscribe(INotificationObserver observer)
    {
        _observers.Add(observer);
    }


    public void Unsubscribe(INotificationObserver observer)
    {
        _observers.Remove(observer);
    }


    public void NotifyAll(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(message);
        }
    }
}
