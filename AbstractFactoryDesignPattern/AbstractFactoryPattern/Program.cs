using AbstractFactoryPattern.AbstractFactoryClass;
using AbstractFactoryPattern.ClientClass;
using AbstractFactoryPattern.ConcreteFactory;
using AbstractFactoryPattern.ConcreteFactoryClass;

class Program {
    static void Main(string[] args) {
        // Choose the factory based on the platform (e.g., Windows or Mac)
        IGUIFactory factory;

        Console.WriteLine("Enter the platform (Windows/Mac): ");
        string platform = Console.ReadLine()?.ToLower();

        if (platform == "windows") {
            factory = new WindowsFactory();
        }
        else if (platform == "mac") {
            factory = new MacFactory();
        }
        else {
            Console.WriteLine("Invalid platform selected. Defaulting to Windows.");
            factory = new WindowsFactory();
        }

        // Create application with the selected factory
        Application app = new Application(factory);
        app.CreateUI();
    }
}