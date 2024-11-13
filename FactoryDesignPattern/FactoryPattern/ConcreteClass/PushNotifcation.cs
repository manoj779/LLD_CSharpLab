using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.ConcreteClass;

public class PushNotifcation: INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine("Sending Push: " + message);
    }
}
