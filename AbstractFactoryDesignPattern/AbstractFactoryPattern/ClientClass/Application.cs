using System;
using AbstractFactoryPattern.AbstractFactoryClass;
using AbstractFactoryPattern.AbstractProductClass;

namespace AbstractFactoryPattern.ClientClass;

// Client Code
public class Application {
    private readonly IButton _button;
    private readonly IWindow _window;

    public Application(IGUIFactory factory) {
        _button = factory.CreateButton();
        _window = factory.CreateWindow();
    }

    public void CreateUI() {
        _button.Render();
        _window.Show();
    }
}