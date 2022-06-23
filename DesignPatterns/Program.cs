

// See https://aka.ms/new-console-template for more information
using Patterns.Decorator;

Console.WriteLine("Hello, World!");

BaseBeverage coffee = new BDecafCoffee();

coffee = new DSweetener(coffee);



Console.WriteLine($"Producto: {coffee.Description} tiene un costo de: ${coffee.Cost}");


