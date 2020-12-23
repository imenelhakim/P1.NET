using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Category : Concept{

        public int CategoryId { get; set; }
        public String Name { get; set; }

        public virtual List<Product> products { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine($"{Name}");
            System.Console.ReadKey();
        }
    }
}

