using Microsoft.EntityFrameworkCore;
using AutoMapper;
using alpha_naf_poc.Domain.Interfaces;
using alpha_naf_poc.Service;
using alpha_naf_poc.Repository;
using alpha_naf_poc.Context;
using alpha_naf_poc.Interfaces;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<NewsArticlesContext>(opts =>
    opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddHttpClient<IExternalApi>(client =>
{
    client.BaseAddress = new Uri("https://newsapi.org/v2");
}).AddTypedClient(client => Refit.RestService.For<IExternalApi>(client));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Services.AddScoped<INewsRepository, NewsRepository>();
builder.Services.AddScoped<INewsService, NewsService>();

builder.Services.AddControllers().AddNewtonsoftJson();

// Add services to the container.
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