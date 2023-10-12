using FlowerStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FlowerStoreContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("FlowerStore"));
});

//Add cors
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    //add Cors
    app.UseCors(builder =>
    {
        builder.AllowAnyOrigin() //cho phep truy cap bat ky
                .AllowAnyMethod() //cho phep method
                .AllowAnyHeader();//cho phep tieu de
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
