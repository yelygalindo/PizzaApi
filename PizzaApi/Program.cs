using PizzaApi.Pedido.Interfaces;
using PizzaApi.Pizza.Factory;
using PizzaApi.Pizza.Recipes;
using Pizzas.Pedido;
using Pizzas.Pizza.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IRecipe, MargharitaPizza>();
builder.Services.AddScoped<IRecipe, PepperoniPizza>();

builder.Services.AddScoped<IPromotionStrategy, RegularPromotionStrategy>();
builder.Services.AddScoped<IPromotionStrategy, TwoForOnePromotionStrategy>();
builder.Services.AddScoped<IPromotionStrategy, FreeDeliveryPromotionStrategy>();

builder.Services.AddScoped<IPromocionContext, PromocionContext>();

builder.Services.AddScoped<IPizzaFactory, PizzaFactory>();

builder.Services.AddControllers();
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
