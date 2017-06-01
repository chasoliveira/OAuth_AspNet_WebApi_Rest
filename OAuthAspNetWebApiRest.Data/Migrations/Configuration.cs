namespace OAuthAspNetWebApiRest.Data.Migrations
{
    using Domain.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OAuthAspNetWebApiRest.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OAuthAspNetWebApiRest.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Products.AddOrUpdate(
              p => p.Name,
              new Product { Name = "Rice", Quantity = 5 },
              new Product { Name = "Bean" , Quantity = 10},
              new Product { Name = "Tomato", Quantity = 15 }
            );

        }
    }
}
