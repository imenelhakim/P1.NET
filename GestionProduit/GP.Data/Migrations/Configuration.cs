namespace GP.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using GP.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<GP.Data.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GP.Data.Model1 context)
        {
            Category cat = new Category() { Name = "Legume" };
            context.Categories.AddOrUpdate(c=>c.Name,cat);
            context.SaveChanges();
            /* persister les donnees: ajouter DbSet<Category>
             * enregirstrer : save*/


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
