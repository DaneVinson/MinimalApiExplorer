using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Domain;

public static class CalculatorEndpointHandler
{
    public static IResult HandleAddEndpoint(
        [FromServices] ICalculator calculator, 
        [FromRoute] decimal a, 
        [FromRoute] decimal b)
    {
        var result = calculator.Add(new Arguments(a, b));
        return GetResult(result);
    }

    public static IResult HandleDivide(
        [FromServices] ICalculator calculator,
        [FromRoute] decimal a,
        [FromRoute] decimal b)
    {
        var result = calculator.Divide(new Arguments(a, b));
        return GetResult(result);
    }

    public static IResult HandleMultiply(
        [FromServices] ICalculator calculator,
        [FromRoute] decimal a,
        [FromRoute] decimal b)
    {
        var result = calculator.Multiply(new Arguments(a, b));
        return GetResult(result);
    }

    public static IResult HandleRootEndpoint([FromServices] AppConfig config) => 
        Results.Ok($"{config.Greeting} {config.Person}, welcome to the silly calculator API");

    public static IResult HandleSubtract(
        [FromServices] ICalculator calculator, 
        [FromRoute] decimal a, 
        [FromRoute] decimal b)
    {
        var result = calculator.Subtract(new Arguments(a, b));
        return GetResult(result);
    }

    private static IResult GetResult(CalculationResult result)
    {
        return result.Error switch
        {
            "" => Results.Ok(result.Value),
            _ => Results.BadRequest(result.Error)
        };
    }
}