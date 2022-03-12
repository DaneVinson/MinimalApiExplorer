namespace Domain;

public interface ICalculationHandler
{
    CalculationResult HandleAdd(decimal a, decimal b); 
    CalculationResult HandleDivide(decimal a, decimal b);
    CalculationResult HandleMultiply(decimal a, decimal b);
    CalculationResult HandleSubtract(decimal a, decimal b);
}