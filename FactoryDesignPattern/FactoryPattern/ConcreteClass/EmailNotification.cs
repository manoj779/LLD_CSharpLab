using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.ConcreteClass;

public class EmailNotification: INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine("Sending Email: " + message);
    }
}