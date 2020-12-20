using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Category{

        public int CategoryId { get; set; }
        public String Name { get; set; }

        public List<Product> products { get; set; }
    }
}
