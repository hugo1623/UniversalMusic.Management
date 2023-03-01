using Microsoft.EntityFrameworkCore;
using UniversalMusic.Management.Application.Implementations;
using UniversalMusic.Management.Application.Interfaces;
using UniversalMusic.Management.Repository;
using UniversalMusic.Management.Repository.Implementations;
using UniversalMusic.Management.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ManagementContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));
builder.Services.AddScoped<IDiscsApplication, DiscsApplication>();
builder.Services.AddScoped<IDiscsRepository, DiscsRepository>();

builder.Services.AddScoped<IArtistsApplication, ArtistsApplication>();
builder.Services.AddScoped<IArtistsRepository, ArtistsRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
