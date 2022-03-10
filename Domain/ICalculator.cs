using System.Text;

namespace Domain;

public interface ICalculator
{
    CalculationResult Add(Arguments arguments);
    CalculationResult Divide(Arguments arguments);
    CalculationResult Multiply(Arguments arguments);
    CalculationResult Subtract(Arguments arguments);
}
