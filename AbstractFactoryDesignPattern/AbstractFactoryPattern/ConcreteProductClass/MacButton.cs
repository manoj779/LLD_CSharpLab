using System;
using AbstractFactoryPattern.AbstractProductClass;

namespace AbstractFactoryPattern.ConcreteProductClass;

// Concrete Product for Mac Button
public class MacButton : IButton
{
    public void Render()
    {
         Console.WriteLine("Rendering Mac-style button.");
    }
}
