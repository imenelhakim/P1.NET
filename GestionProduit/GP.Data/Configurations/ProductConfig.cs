using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GP.Domain;

namespace GP.Data.Configurations
{
    class ProductConfig: EntityTypeConfiguration<Product>
    {
        //ctor
        public ProductConfig()
        {
            ToTable("les_produits"); //quelle entitée doit être configurée
                                                                    //modelBuilder.Entity<Product>().HasKey(p => new { p.ProductId, p.Name }); //clé primaire composée
                                                                    //modelBuilder.Entity<Product>().HasKey(p => p.ProductId); //quelle est la clé primaire

            Property(p => p.Name).HasMaxLength(50).IsRequired().HasColumnName("nomProduit").HasColumnType("varchar").HasColumnOrder(5); //configuration


            //base.OnModelCreating(modelBuilder); // modelBuilder objet
        }
    }
}
