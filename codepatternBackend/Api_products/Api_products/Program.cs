using Api_products;
using Api_products.Factories;
using Api_products.Handlers;
using Api_products.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// dependency-inversion-principle, har gjort depency injection. 

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Sqlcontext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\julia\OneDrive\Dokument\Database.mdf;Integrated Security=True;Connect Timeout=30"));
builder.Services.AddSingleton<IProductFactory, ProductFactory>();
builder.Services.AddScoped<IProductHandler, ProductHandler>();
builder.Services.AddCors(options =>
    options.AddPolicy("default", policy =>
    {
        policy.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod();
    }));


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseCors("default");
app.Run();
