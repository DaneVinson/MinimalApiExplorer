using System.Text;

namespace Domain;

public interface ICalculator
{
    CalculationResult Add(CalculationArguments calculationArguments);
    CalculationResult Divide(CalculationArguments calculationArguments);
    CalculationResult Multiply(CalculationArguments calculationArguments);
    CalculationResult Subtract(CalculationArguments calculationArguments);
}
