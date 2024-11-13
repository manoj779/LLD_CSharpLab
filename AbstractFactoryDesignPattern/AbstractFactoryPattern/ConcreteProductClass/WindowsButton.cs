using System;
using AbstractFactoryPattern.AbstractProductClass;

namespace AbstractFactoryPattern.ConcreteProductClass;

// Concrete Product for Windows Button
public class WindowsButton : IButton
{
    public void Render()
    {
      Console.WriteLine("Rendering Windows-style button.");
    }
}
