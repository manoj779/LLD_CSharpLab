using System;
using FactoryPattern.Interfaces;

namespace FactoryPattern.ConcreteClass;

public class BotNotification : INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine(message);
    }
}
