using System;
using System.Configuration;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ApiContext;
using System.Text.Json.Serialization;
 
using Application.Contracts;
using Infrastructure;
using Application.Features.Products.Queries.GetAllQuery;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DBContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("ApiDataBase")));
//builder.Services.AddControllers().AddJsonOptions(x =>
//                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddMediatR(config =>
{ config.RegisterServicesFromAssembly(typeof(GetAllProductsQuery).Assembly); }) ;
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddControllers();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.MapDefaultControllerRoute();
app.Run();
