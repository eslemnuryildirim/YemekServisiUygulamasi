using Ecommerce.Infrastructure.Context;
using Ecommerce.Infrastructure.Repositories;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Services;
using Ecommerce.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Ecommerce.WebAPI.Extensions;




var builder = WebApplication.CreateBuilder(args);

// MS-SQL Connection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<EcommerceDbContext>(options => options.UseSqlServer(connectionString));

// Register Services and Repositories
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

// Add Controllers
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    // Veritabanýný oluþtur ve güncelle
    await app.InitialiseDatabaseAsync();
}

app.MapControllers();
app.Run();
