using API_Tutorial.Options;
using Microsoft.OpenApi.Models;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(x =>
{
    x.SwaggerDoc("v1",new OpenApiInfo { Title = "API Tutorial", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


var swaggerOptions = new SwaggerOptions();
builder.Configuration.GetSection(nameof(SwaggerOptions)).Bind(swaggerOptions);

app.UseSwagger(options =>
{
    options.RouteTemplate = swaggerOptions.JsonRoute;
});

app.UseSwaggerUI(options => options.SwaggerEndpoint(swaggerOptions.UiEndpoint, swaggerOptions.Description));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
