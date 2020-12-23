using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GP.Domain;

namespace GP.Data.Configurations
{
    public class CategoryConfig: EntityTypeConfiguration<Category>
    {
        public CategoryConfig()
        {
            ToTable("Categories");
            HasKey(c => c.CategoryId);
            Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}
