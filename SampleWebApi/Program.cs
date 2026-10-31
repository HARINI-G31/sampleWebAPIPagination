using Scalar.AspNetCore;
using SampleWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi(); // support openAPI
builder.Services.AddSingleton<StudentService>();

var app = builder.Build(); //like dotnet Build

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
    
}

app.UseHttpsRedirection(); // if need to change https we can http

app.UseAuthorization();

app.MapControllers();

app.Run();
