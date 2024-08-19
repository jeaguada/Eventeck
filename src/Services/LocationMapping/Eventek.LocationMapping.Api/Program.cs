var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/api/location", () =>
"hola soy location!");

app.Run();