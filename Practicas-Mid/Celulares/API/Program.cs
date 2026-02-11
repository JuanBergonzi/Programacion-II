using CDatos.Context;
using CDatos.Repositorios;
using CLogica.Implementation;
using CLogica.Implementation.Contracts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DbContext con SQL Server
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Razor Pages
builder.Services.AddRazorPages();

// Controllers para API
builder.Services.AddControllers();

// Registrar servicios de lógica y repositorios
builder.Services.AddScoped<ICelularService, CelularService>();
builder.Services.AddScoped<ICelularRepositorio, CelularRepositorio>();

// Swagger / OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CORS (para desarrollo local)
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// CORS
app.UseCors();

app.UseRouting();
app.UseAuthorization();

// Mapear endpoints
app.MapRazorPages();
app.MapControllers();

app.Run();
