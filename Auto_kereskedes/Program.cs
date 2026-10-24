using Application.Repositries;
using Application.Services;
using Infrastructure;
using Infrastructure.Repositories;
using Infrastructure.Servicies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddTransient<IAutoKereskedesService, AutoKereskedesService>();
builder.Services.AddTransient<IAutoKereskedesRepository, AutoKereskedesRepository>();

builder.Services.AddDbContext<ApplicationDbContext>(config =>
    config.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
