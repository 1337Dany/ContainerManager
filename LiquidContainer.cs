namespace Container;

public class LiquidContainer : HazardousContainer
{
    private readonly double _allowedMaxPayload;
    
    public LiquidContainer(
        double height,
        double depth,
        double tareWeight,
        double masPayload,
        bool isCargoHazardous)
        : base(
            height,
            depth,
            tareWeight,
            masPayload, 
            'L')
    {
        isCargoHazardous = isCargoHazardous;
        var capacityLimit = IsCargoHazardous ? 0.5 : 0.9;
        _allowedMaxPayload = MaxPayload * capacityLimit;
    }
    
    public bool IsCargoHazardous { get; }

    protected override bool CanLoadCargo(double mass) => CargoMass + mass <= _allowedMaxPayload;
}