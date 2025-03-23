using Container.Enums;

namespace Container;

public class RefrigeratedContainer : Container
{
    public RefrigeratedContainer(double height, double depth, double tareWeight, double masPayload, ProductType productType, double maintainedTemperature)
        : base(height, depth, tareWeight, masPayload, 'C')
    {
        if (TemperatureValidator.IsValid(productType, maintainedTemperature))
        {
            ProductType = productType;
            MaintainedTemperature = maintainedTemperature;
            
        }
    }

    public double MaintainedTemperature { get; }
    public ProductType ProductType { get; }
}