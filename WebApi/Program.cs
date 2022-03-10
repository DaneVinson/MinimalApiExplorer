using WebApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services
        .AddSingleton(builder.Configuration.GetSection(nameof(AppConfig)).Get<AppConfig>())
        .AddSingleton<ICalculator, Calculator>();

var app = builder.Build();

app.MapCalculatorEndpoints();

app.Run();
