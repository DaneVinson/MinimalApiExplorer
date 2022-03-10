namespace Domain;

public class CalculationResult
{
    public CalculationResult()
    {}

    public CalculationResult(decimal value)
    {
        Value = value;
    }

    public CalculationResult(string error)
    {
        Error = error;
    }
    
    public string Error { get; set; } = string.Empty;
    public decimal Value { get; set; }
}