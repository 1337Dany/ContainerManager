using Container.Enums;

namespace Container;

public class RefrigeratedContainer : Container
{
    public RefrigeratedContainer(double height, double depth, double tareWeight, double maxPayload, ProductType productType, double maintainedTemperature)
        : base(height, depth, tareWeight, maxPayload, 'C')
    {
        if (TemperatureValidator.IsValid(productType, maintainedTemperature))
        {
            ProductType = productType;
            MaintainedTemperature = maintainedTemperature;
            
        }
    }

    public double MaintainedTemperature { get; }
    public ProductType ProductType { get; }
    
    public override string ToString()
    {
        return $"Container Heigh: {Height}," +
               $" Depth: {Depth}," +
               $" Weight: {TareWeight} kg," +
               $" Max Payload: {MaxPayload}," +
               $" Maintained Temperature: {MaintainedTemperature}," +
               $" Product Type: {ProductType}" +
               $" Container Type: {ContainerType}";
    }
}