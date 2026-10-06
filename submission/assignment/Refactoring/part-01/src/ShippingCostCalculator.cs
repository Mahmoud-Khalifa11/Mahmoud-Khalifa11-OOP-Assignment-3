namespace RefactoringLab;

public interface ICarrier
{
    string Name { get; }
    decimal Calculate(decimal weightKg);
}

public class AramexCarrier : ICarrier
{
    public string Name => "Aramex";
    public decimal Calculate(decimal weightKg) => weightKg * 12m;
}

public class FedExCarrier : ICarrier
{
    public string Name => "FedEx";
    public decimal Calculate(decimal weightKg) => weightKg * 15m;
}

public class DhlCarrier : ICarrier
{
    public string Name => "DHL";
    public decimal Calculate(decimal weightKg) => weightKg * 18m;
}

public class ShippingCostCalculator
{
    private readonly Dictionary<string, ICarrier> _carriers;

    public ShippingCostCalculator(IEnumerable<ICarrier> carriers) =>
        _carriers = carriers.ToDictionary(c => c.Name);

    public decimal Calculate(string carrier, decimal weightKg) =>
        _carriers.TryGetValue(carrier, out var c)
            ? c.Calculate(weightKg)
            : throw new ArgumentException($"Unknown carrier: {carrier}");
}

