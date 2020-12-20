using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Product : Concept {

        public DateTime DateProd { get; set; }
        public String Description { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Category category { get; set; }
        public List<Provider> providers { get; set; }

        //instantiation de la liste 
        public Product()
        {
            this.providers = new List<Provider>();
        }

        public Product(string name,DateTime dateProd, int quantity, double price)
        {
            Name = name;
            DateProd = dateProd;
            Quantity = quantity;
            Price = price;
        }

        public Product(DateTime dateProd, string description, string name, double price, int productId, int quantity)
        {
            DateProd = dateProd;
            Description = description;
            Name = name;
            Price = price;
            ProductId = productId;
            Quantity = quantity;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"{ProductId} | {Name} | {Description} | {DateProd} | {Price} | {Quantity}");
            Console.ReadKey();
        }

        public virtual void GetMyType()
        {
            Console.WriteLine("UNKNOWN");
        }



    }
}
