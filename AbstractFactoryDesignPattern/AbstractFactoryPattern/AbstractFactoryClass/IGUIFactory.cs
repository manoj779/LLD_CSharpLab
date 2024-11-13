using System;
using AbstractFactoryPattern.AbstractProductClass;

namespace AbstractFactoryPattern.AbstractFactoryClass;

// Abstract Factory Interface
public interface IGUIFactory
{
     IButton CreateButton();
    IWindow CreateWindow();
}
