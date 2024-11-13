using System;
using FactoryPattern.ConcreteClass;
using FactoryPattern.Interfaces;

namespace FactoryPattern.FactoryClass.ConcreteFactoryClass;

public class SmsNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new SmsNotification();
    }
}