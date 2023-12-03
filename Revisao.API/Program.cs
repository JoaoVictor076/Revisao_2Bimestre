using AutoMapper;
using H1Store.Catalogo.Data.Providers.MongoDb.Interfaces;
using ListaH1.Data.AutoMapper;
using ListaH1.Data.Providers.MongoDb;
using ListaH1.Data.Providers.MongoDb.Configuration;
using Microsoft.Extensions.Options;
using Revisao.Application.AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.Services;
using Revisao.Data.Repository;
using Revisao.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(DomainToApplication), typeof(ApplicationToDomain));

builder.Services.AddAutoMapper(typeof(DomainToCollection), typeof(CollectionToDomain));

builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("MongoDbSettings"));

builder.Services.AddSingleton<IMongoDbSettings>(serviceProvider =>
       serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);

builder.Services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));

builder.Services.AddScoped<ICartasRepository, CartasRepository>();
builder.Services.AddScoped<ICartaService, CartaService>();



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
