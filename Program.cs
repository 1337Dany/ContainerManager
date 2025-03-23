// See https://aka.ms/new-console-template for more information

using Container;
using Container.Enums;

LiquidContainer liquidContainer = new LiquidContainer(50,50, 100,200, false);
GasContainer gasContainer = new GasContainer(50,50,30,100, 12.5);
RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer(50,50,100,200, ProductType.FrozenPizza, -4.0);
HazardousContainer hazardousContainer = new GasContainer(50,50,30,200, 5.0);

Transport transport = new Transport(10.5, 10, 2000);

transport.AddContainer(liquidContainer);
transport.AddContainer(gasContainer);

transport.ShowContainers();

transport.ReplaceContainerByIndex(1, hazardousContainer);

Console.WriteLine();

transport.ShowContainers();

Console.WriteLine();

transport.PrintInfo();