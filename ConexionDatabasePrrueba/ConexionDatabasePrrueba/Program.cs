using ConexionDatabasePrrueba.Interfaces;
using ConexionDatabasePrrueba.Models;
using ConexionDatabasePrrueba.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var conn = builder.Configuration.GetConnectionString("AppConnection");
builder.Services.AddDbContext<P2Context>(op => op.UseSqlServer(conn));
builder.Services.AddScoped<Iusuario,GestorUsuario>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
