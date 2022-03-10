namespace Domain;

public class Calculator : ICalculator
{
    public CalculationResult Add(Arguments arguments)
    {
        return new CalculationResult(arguments.A + arguments.B);
    }

    public CalculationResult Divide(Arguments arguments)
    {
        return arguments.B switch
        {
            0 => new CalculationResult("Cannot divide by zero"),
            _ => new CalculationResult(arguments.A / arguments.B)
        };
    }

    public CalculationResult Multiply(Arguments arguments)
    {
        return new CalculationResult(arguments.A * arguments.B);
    }

    public CalculationResult Subtract(Arguments arguments)
    {
        return new CalculationResult(arguments.A - arguments.B);
    }
}