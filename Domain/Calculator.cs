namespace Domain;

public class Calculator : ICalculator
{
    public CalculationResult Add(CalculationArguments calculationArguments)
    {
        return new CalculationResult(calculationArguments.A + calculationArguments.B);
    }

    public CalculationResult Divide(CalculationArguments calculationArguments)
    {
        return calculationArguments.B switch
        {
            0 => new CalculationResult("Cannot divide by zero"),
            _ => new CalculationResult(calculationArguments.A / calculationArguments.B)
        };
    }

    public CalculationResult Multiply(CalculationArguments calculationArguments)
    {
        return new CalculationResult(calculationArguments.A * calculationArguments.B);
    }

    public CalculationResult Subtract(CalculationArguments calculationArguments)
    {
        return new CalculationResult(calculationArguments.A - calculationArguments.B);
    }
}