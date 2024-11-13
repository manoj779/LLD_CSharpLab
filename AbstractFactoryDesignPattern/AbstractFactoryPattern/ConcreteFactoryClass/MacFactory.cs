using System;
using AbstractFactoryPattern.AbstractFactoryClass;
using AbstractFactoryPattern.AbstractProductClass;
using AbstractFactoryPattern.ConcreteProductClass;

namespace AbstractFactoryPattern.ConcreteFactoryClass;

// Concrete Factory for Mac platform
public class MacFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public IWindow CreateWindow()
    {
        return new MacWindow();
    }
}
