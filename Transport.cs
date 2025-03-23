namespace Container;

public class Transport
{
    private List<Container> containers = new List<Container>();
    private int currentCapacity = 0;
    private double currentWeight = 0;
    
    protected Transport(
        double speed,
        int capacity,
        double weight
    )
    {
        Speed = speed > 0 ? speed : throw new ArgumentException("Speed must be greater than zero");
        Capacity = capacity > 0 ? capacity : throw new ArgumentException("Capacity must be greater than zero");
        Weight = weight > 0 ? weight : throw new ArgumentException("Weight must be greater than zero");
    }

    public double Speed { get; set; }
    public int Capacity { get; set; }
    public double Weight { get; set; }
    public List<Container> Containers { get; set; }

    public void AddContainer(Container container)
    {
        if (currentWeight + container.CargoMass > Weight && currentCapacity + 1 <= Capacity)
        {
            containers.Add(container);
            currentCapacity += 1;
            currentWeight += container.CargoMass;
        }
        else
        {
            throw new OverloadException("Cannot add container because of the overload");
        }
    }

    public void RemoveContainer(Container container)
    {
        containers.Remove(container);
        currentCapacity -= 1;
        currentWeight -= container.CargoMass;
    }
    
}