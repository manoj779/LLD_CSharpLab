using System;
using FactoryPattern.FactoryClass;

namespace FactoryPattern.ServiceClass;

public class NotificationService
{
    private readonly NotificationFactory _factory;

    public NotificationService(NotificationFactory factory)
    {
        _factory = factory;
    }

    public void Send(string message)
    {
        _factory.Notify(message);
    }
}