namespace GP.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using GP.Domain;
    using Configurations;

    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'GP.Data.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
        }

        //Fluent API

        //appel de la methode onmodelcreating de la classe mère
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductConfig());
            modelBuilder.Configurations.Add(new CategoryConfig());
            //goto ProductConfig.cs
            //modelBuilder.Entity<Product>().ToTable("les_produits"); //quelle entitée doit être configurée
            //                                                        //modelBuilder.Entity<Product>().HasKey(p => new { p.ProductId, p.Name }); //clé primaire composée
            //                                                        //modelBuilder.Entity<Product>().HasKey(p => p.ProductId); //quelle est la clé primaire

            //modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(50).IsRequired().HasColumnName("nomProduit").HasColumnType("varchar").HasColumnOrder(5); //configuration


            ////base.OnModelCreating(modelBuilder); // modelBuilder objet
        }


        //creation d'images de la bd 
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}