using Ecommerce.Infrastructure.Context;
using Ecommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;



namespace Ecommerce.WebAPI.Extensions
{
    public static class DatabaseExtensions
    {
        public static async Task InitialiseDatabaseAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            try
            {
                var context = scope.ServiceProvider.GetRequiredService<EcommerceDbContext>();

                context.Database.MigrateAsync().GetAwaiter().GetResult();

                await SeedAsync(context);
            }
            catch (Exception ex)
            {
                var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, "An error occurred while migrating or initializing the database.");
            }
        }

        private static async Task SeedAsync(EcommerceDbContext context)
        {
            await SeedProductAsync(context);
        }

        private static async Task SeedProductAsync(EcommerceDbContext context)
        {
            if (!await context.Products.AnyAsync())
            {
                await context.Products.AddRangeAsync(InitialData.Products);
                await context.SaveChangesAsync();
            }
        }
    }
}
