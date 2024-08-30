using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using pruebaBackend.Domain.Repositories;
using pruebaBackend.Infrastructure;
using pruebaBackend.Infrastructure.Repositories;
using pruebaBackend.WebApi.ApplicationService;
using pruebaBackend.WebApi.Queries;

var builder = WebApplication.CreateBuilder(args);

//Add db conect
builder.Services.AddDbContext<DatabaseContext>(options =>
options.UseSqlServer("Server=(localdb)\\local;Database=pruebaBackend;User Id=sa3;Password=Administrator2")
);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<CarService>();
builder.Services.AddScoped<ICarQueries, CarQueries>();
builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<IBrandRepository, BrandRepository>();


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
