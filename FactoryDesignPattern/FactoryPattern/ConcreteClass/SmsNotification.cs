using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.ConcreteClass;

public class SmsNotification: INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }
}
