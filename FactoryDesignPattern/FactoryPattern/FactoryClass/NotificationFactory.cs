using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.FactoryClass;

public abstract class NotificationFactory
{
    public abstract INotification CreateNotification();

    public void Notify(string message)
    {
        // Create a notification object and send the message
        INotification notification = CreateNotification();
        notification.SendNotification(message);
    }
}