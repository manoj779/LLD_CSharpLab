using System;
using FactoryPattern.ConcreteClass;
using FactoryPattern.Interfaces;

namespace FactoryPattern.FactoryClass.ConcreteFactoryClass;

public class EmailNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new EmailNotification();
    }
}