using WebApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services
        .AddSingleton(builder.Configuration.GetSection(nameof(AppOptions)).Get<AppOptions>())
        .AddSingleton<ICalculationHandler, CalculationHandler>()
        .AddSingleton<ICalculator, Calculator>();

var app = builder.Build();

app.MapCalculatorEndpoints();

app.Run();
