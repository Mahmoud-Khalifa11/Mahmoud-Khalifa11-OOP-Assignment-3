namespace RefactoringLab;

public class BostaCarrier : ICarrier
{
    public string Name => "Bosta";
    public decimal Calculate(decimal weightKg) => weightKg * 10m;
}
