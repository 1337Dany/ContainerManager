namespace Container;

public abstract class Container
{
    private const string ContierPrefix = "KON";
    private static int _nextSerialNumber = 1;

    protected Container(
        double height,
        double depth,
        double tareWeight,
        double maxPayload,
        char containerType
    )
    {
        Height = height > 0 ? height : throw new ArgumentException("Height must be greater than zero");
        Depth = depth > 0 ? depth : throw new ArgumentException("Depth must be greater than zero");
        TareWeight = tareWeight > 0 ? tareWeight : throw new ArgumentException("TareWeight must be greater than zero");
        MaxPayload = maxPayload > 0 ? maxPayload : throw new ArgumentException("MaxPayload must be greater than zero");
        SerialNumber = $"{ContierPrefix}-{containerType}-{_nextSerialNumber++}";
    }

    public double Height { get; set; }
    public double Depth { get; set; }
    public double TareWeight { get; set; }
    public double MaxPayload { get; set; }
    public string SerialNumber { get; set; }
    public double CargoMass { get; set; }

    public virtual void LoadCargo(double mass)

    {
        if(mass <= 0) throw new ArgumentException("Mass must be greater than zero");
        
        if(CargoMass + mass > MaxPayload) throw new OverfillException("Cargo Mass must be less than MaxPayload");
        
        CargoMass += mass;
    }
    
    public virtual void EmptyCargoMass() => CargoMass = 0;
    
    protected virtual bool CanLoadCargo(double mass) => CargoMass + mass > MaxPayload;
}