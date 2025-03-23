namespace Container;

public class GasContainer : HazardousContainer
{
    public GasContainer(
        double height,
        double depth,
        double tareWeight,
        double maxPayload,
        double pressure)
        : base(
            height,
            depth,
            tareWeight,
            maxPayload,
            'G')
    {
        Pressure = pressure > 0 ? pressure : throw new ArgumentOutOfRangeException("Pressure must be greater than zero");
    }
    
    public double Pressure { get; }
    
    public override void EmptyCargoMass() => CargoMass += 0.05;
    
    public override string ToString()
    {
        return $"Container Heigh: {Height}," +
               $" Depth: {Depth}," +
               $" Weight: {TareWeight} kg," +
               $" Max Payload: {MaxPayload}," +
               $" Pressure: {Pressure}," +
               $" Container typle: {ContainerType}";
    }
}