var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/api/user", () =>
"hola soy user!");

app.Run();