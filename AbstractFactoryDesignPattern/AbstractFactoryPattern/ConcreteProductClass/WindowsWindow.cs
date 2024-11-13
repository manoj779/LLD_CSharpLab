using System;
using AbstractFactoryPattern.AbstractProductClass;

namespace AbstractFactoryPattern.ConcreteProductClass;

// Concrete Product for Windows Window
public class WindowsWindow : IWindow
{
    public void Show()
    {
        Console.WriteLine("Displaying Windows-style window.");
    }
}
