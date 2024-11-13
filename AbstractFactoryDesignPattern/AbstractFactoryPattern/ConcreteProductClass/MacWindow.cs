using System;
using AbstractFactoryPattern.AbstractProductClass;

namespace AbstractFactoryPattern.ConcreteProductClass;

// Concrete Product for Mac Window
public class MacWindow : IWindow
{
    public void Show()
    {
        Console.WriteLine("Displaying Mac-style window.");
    }
}
