var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var mensaje = Environment.GetEnvironmentVariable("MENSAJE") ?? "No hay mensaje";
    return mensaje;
});

app.Run();
