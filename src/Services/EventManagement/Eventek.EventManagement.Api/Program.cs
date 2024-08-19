var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/api/event", () =>
"hola soy event!");
app.Run();


