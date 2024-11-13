using System;
using AbstractFactoryPattern.AbstractFactoryClass;
using AbstractFactoryPattern.AbstractProductClass;
using AbstractFactoryPattern.ConcreteProductClass;

namespace AbstractFactoryPattern.ConcreteFactory;

// Concrete Factory for Windows platform
public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public IWindow CreateWindow()
    {
        return new WindowsWindow();
    }
}
