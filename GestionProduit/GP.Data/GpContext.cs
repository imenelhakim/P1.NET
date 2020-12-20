
using GP.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data
{
    public class GpContext : DbContext
    {
        //définir la BD + nom serveur
        public GpContext():base("name=GPConnection") 
        {
            /*appel du ctor de la classe mère 
             * base("GestionProduitsDB") : l'EF va créer une BD ayant pour nom GestionProduitsDB
             * sans param : {namespace}.{nomClasseContexte}
             * base("name=ConnexionDB") > EF va chercher cette base dans app.config
            */
        }

        //creation d'images de la bd 
        public DbSet<Provider> providers { get; set; }
        public DbSet<Product> products{ get; set; }
        public DbSet<Category> categories{ get; set; }
    }
}
