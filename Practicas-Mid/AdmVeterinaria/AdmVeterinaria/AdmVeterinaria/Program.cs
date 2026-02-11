using AdmVeterinaria.Datos;
using AdmVeterinaria.Logica.AnimalLogic;
using AdmVeterinaria.Logica.AtencionLogic;
using AdmVeterinaria.Logica.DuenioLogic;
using AdmVeterinaria.Logica.MedicamentoLogic;
using AdmVeterinaria.Logica.TipoAnimal;
using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add Database Context
builder.Services.AddDbContext<TodoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBContext"))
);

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<TodoContext>();
    context.Database.EnsureCreated();
    DbInitializer.Initialize(context);
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//Inyeciones de dependencias 
builder.Services.AddScoped<IAnimalLogic, AnimalLogic>();
builder.Services.AddScoped<IAtencionLogic, AtencionLogic>();
builder.Services.AddScoped<IDuenioLogic, DuenioLogic>();
builder.Services.AddScoped<IMedicamentoLogic, MedicamentoLogic>();
builder.Services.AddScoped<ITipoAnimalLogic, TipoAnimalLogic>();




