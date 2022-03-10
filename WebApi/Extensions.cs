namespace WebApi;

public static class Extensions
{
    public static void MapCalculatorEndpoints(this WebApplication app)
    {
        app.MapGet("/", CalculatorEndpointHandler.HandleRootEndpoint);
        app.MapGet("/{a}/add/{b}", CalculatorEndpointHandler.HandleAddEndpoint);
        app.MapGet("/{a}/subtract/{b}", CalculatorEndpointHandler.HandleSubtract);
        app.MapGet("/{a}/multiply/{b}", CalculatorEndpointHandler.HandleMultiply);
        app.MapGet("/{a}/divide/{b}", CalculatorEndpointHandler.HandleDivide);
    }
}