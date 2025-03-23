namespace Container;

public class GasContainer : HazardousContainer
{
    public GasContainer(
        double height,
        double depth,
        double tareWeight,
        double masPayload,
        double pressure)
        : base(
            height,
            depth,
            tareWeight,
            masPayload,
            'G')
    {
        Pressure = pressure > 0 ? pressure : throw new ArgumentOutOfRangeException("Pressure must be greater than zero");
    }
    
    public double Pressure { get; }
    
    public override void EmptyCargoMass() => CargoMass += 0.05;
}