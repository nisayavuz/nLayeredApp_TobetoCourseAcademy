using Business;
using Business.Automapper;
using Core.Entities;
using DataAccess;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddBusinessServices();
builder.Services.AddDataAccessServices(builder.Configuration);
builder.Services.AddAutoMapper(typeof(CourseMapping));
builder.Services.AddAutoMapper(typeof(InstructorMapping));
builder.Services.AddAutoMapper(typeof(CategoryMapping));

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

app.UseAuthorization();

app.MapControllers();

app.Run();
