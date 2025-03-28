﻿namespace Container;

public abstract class HazardousContainer : Container, IHazardNotifier
{
    protected HazardousContainer(
        double height,
        double depth,
        double tareWeight,
        double maxPayload,
        char containerType) 
        : base(
            height,
            depth,
            tareWeight,
            maxPayload,
            containerType
            )
    {
    }

    public override void LoadCargo(double mass)
    {
        if (mass <= 0) throw new ArgumentException();

        if (!CanLoadCargo(mass))
        {
            NotifyHazard("Cannot load cargo");
            throw new OverfillException("Cannot load cargo");
        }
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"HazardousContainer {SerialNumber}" + $"\nMessage: {message}");
    }
    
    public override string ToString()
    {
        return $"Container Heigh: {Height}," +
               $" Depth: {Depth}," +
               $" Weight: {TareWeight} kg," +
               $" Max Payload: {MaxPayload}," +
               $" Container typle: {ContainerType}";
    }
}