namespace Domain;

public class CalculationHandler : ICalculationHandler
{
    private readonly ICalculator _calculator;

    public CalculationHandler(ICalculator calculator)
    {
        _calculator = calculator ?? throw new ArithmeticException(nameof(calculator));
    }
    
    public CalculationResult HandleAdd(decimal a, decimal b)
    {
        return _calculator.Add(new Arguments(a, b));
    }

    public CalculationResult HandleDivide(decimal a, decimal b)
    { 
        return _calculator.Divide(new Arguments(a, b));
    }

    public CalculationResult HandleMultiply(decimal a, decimal b)
    {
        return _calculator.Multiply(new Arguments(a, b));
    }
    
    public CalculationResult HandleSubtract(decimal a, decimal b)
    {
        return _calculator.Subtract(new Arguments(a, b));
    }
}