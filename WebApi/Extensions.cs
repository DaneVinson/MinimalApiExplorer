namespace WebApi;

public static class Extensions
{
    public static void MapCalculatorEndpoints(this WebApplication app)
    {
        app.MapGet(
            "/", 
            (AppOptions options) => 
                        Results.Ok($"{options.Greeting} {options.Person}, welcome to the silly calculator API"));
        app.MapGet(
            "/{a}/add/{b}", 
            (ICalculationHandler handler, decimal a, decimal b) => 
                        handler.HandleAdd(a, b).GetResult());
        app.MapGet(
            "/{a}/subtract/{b}", 
            (ICalculationHandler handler, decimal a, decimal b) => 
                        handler.HandleSubtract(a, b).GetResult());
        app.MapGet(
            "/{a}/multiply/{b}", 
            (ICalculationHandler handler, decimal a, decimal b) => 
                        handler.HandleMultiply(a, b).GetResult());
        app.MapGet(
            "/{a}/divide/{b}", 
            (ICalculationHandler handler, decimal a, decimal b) => 
                        handler.HandleDivide(a, b).GetResult());
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