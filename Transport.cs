namespace Container;

public class Transport
{
    private List<Container> containers = new List<Container>();
    private int _currentCapacity = 0;
    private double _currentWeight = 0;
    
    public Transport(
        double speed,
        int capacity,
        double weight,
        List<Container>? containers = null
            )
    {
        Speed = speed > 0 ? speed : throw new ArgumentException("Speed must be greater than zero");
        Capacity = capacity > 0 ? capacity : throw new ArgumentException("Capacity must be greater than zero");
        Weight = weight > 0 ? weight : throw new ArgumentException("Weight must be greater than zero");
        Containers = containers;
    }

    public double Speed { get; set; }
    public int Capacity { get; set; }
    public double Weight { get; set; }
    public List<Container>? Containers { get; set; }

    public void AddContainer(Container container)
    {
        if (_currentWeight + container.CargoMass < Weight && _currentCapacity + 1 <= Capacity)
        {
            containers.Add(container);
            _currentCapacity += 1;
            _currentWeight += container.CargoMass;
        }
        else
        {
            throw new OverloadException("Cannot add container because of the overload");
        }
    }

    public void RemoveContainer(Container container)
    {
        containers.Remove(container);
        _currentCapacity -= 1;
        _currentWeight -= container.CargoMass;
    }

    public void ShowContainers()
    {
        for (int i = 0; i < containers.Count; i++)
        {
            Console.WriteLine(containers[i]);
        }
    }

    public void ReplaceContainerByIndex(int index, Container container)
    {
        containers[index] = container;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Ship speed {Speed} km/h, " +
                          $"Ship Max Weight {Weight} kg, " + 
                          $"Ship Max Capacity {Capacity} kg" + 
                          $"Ship Current weight {_currentWeight} kg, " + 
                          $"Ship Current Capacity {_currentCapacity} kg");
        
        Console.WriteLine("Contained containers: ");
        for (int i = 0; i < containers.Count; i++)
        {
            Console.WriteLine(containers[i]);
        }
    }
}