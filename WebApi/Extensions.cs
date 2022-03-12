namespace WebApi;

public static class Extensions
{
    public static void MapCalculatorEndpoints(this WebApplication app)
    {
        app.MapGet("/", (AppOptions options) => Results.Ok($"{options.Greeting} {options.Person}, welcome to the silly calculator API"));
        app.MapGet("/{a}/add/{b}", HandleAddEndpoint);
        app.MapGet("/{a}/subtract/{b}", HandleSubtractEndpoint);
        app.MapGet("/{a}/multiply/{b}", HandleMultiplyEndpoint);
        app.MapGet("/{a}/divide/{b}", HandleDivideEndpoint);
    }
    
    private static IResult HandleAddEndpoint(
        [FromServices] ICalculationHandler handler, 
        [FromRoute] decimal a, 
        [FromRoute] decimal b)
    { 
        return handler.HandleAdd(a, b).GetResult();
    }

    private static IResult HandleDivideEndpoint(
        [FromServices] ICalculationHandler handler, 
        [FromRoute] decimal a, 
        [FromRoute] decimal b)
    { 
        return handler.HandleDivide(a, b).GetResult();
    }

    private static IResult HandleMultiplyEndpoint(
        [FromServices] ICalculationHandler handler, 
        [FromRoute] decimal a, 
        [FromRoute] decimal b)
    { 
        return handler.HandleMultiply(a, b).GetResult();
    }

    private static IResult HandleSubtractEndpoint(
        [FromServices] ICalculationHandler handler, 
        [FromRoute] decimal a, 
        [FromRoute] decimal b)
    { 
        return handler.HandleSubtract(a, b).GetResult();
    }
    
    private static IResult GetResult(this CalculationResult result)
    {
        return result.Error switch
        {
            "" => Results.Ok(result.Value),
            _ => Results.BadRequest(result.Error)
        };
    }
}