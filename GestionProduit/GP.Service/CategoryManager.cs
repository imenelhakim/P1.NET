using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GP.Domain;

namespace GP.Service
{
    public class CategoryManager
    {
        List<Category> categories;

        public CategoryManager(List<Category> categories)
        {
            this.categories = categories;
        }
    }
}
