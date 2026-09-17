var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from aAK's Azure App! Running on .NET 10 🚀");

app.Run();
