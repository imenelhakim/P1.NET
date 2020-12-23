using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace GP.Domain
{
    public class Product : Concept {

        [DataType(DataType.Date,ErrorMessage ="Date non valid.")][Display(Name ="Production Date")]
        public DateTime DateProd { get; set; }

        [DataType(DataType.MultilineText)]
        public String Description { get; set; }

        [Required(ErrorMessage = "Name obligatory")] [StringLength(25,ErrorMessage ="The string length (user input) must be 25.")] [MaxLength(50,ErrorMessage ="Max length in the database is 50")]
        public String Name { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public int ProductId { get; set; }

        [Range(0,int.MaxValue)]
        public int Quantity { get; set; }

        [ForeignKey("category")]
        public int? categoryRef { get; set; }
        public virtual Category category { get; set; }
        public virtual List<Provider> providers { get; set; }

        //migration

        public String Image { get; set; }

        //migration

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
