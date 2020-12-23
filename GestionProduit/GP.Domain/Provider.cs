using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Provider : Concept
    {
        public DateTime DateCreated { get; set; }

        [Required][DataType(DataType.EmailAddress)]
        //ou [EmailAddress]
        public string Email { get; set; }

        [Key]
        public int Id { get; set; }
        public bool IsApproved { get; set; }

        //définir un attribut de type private
        //password entre 5 et 20

        [Required][MinLength(8)][DataType(DataType.Password)]
        private string password;
        public string Password { 
            get{ return password; } 
            set{
                //if (password.Length < 5)
                if (value.Length < 5)
                {
                    Console.WriteLine("Minimum length is 5 ");
                }
                //else if (password.Length > 20)
                else if (value.Length > 20)
                {
                    Console.WriteLine("Maximum length is 20");
                }
                else if( value.Length>5 && value.Length < 20)
                {
                    Console.WriteLine("ACCEPTED");
                }
                password = value;                   //value contient la valeur affectée à la proprieté "password"
                    
            } 
        }        //retoure la valeur de l'attribut password

        private string confirmPassword;

        [Compare("Password")][Required][DataType(DataType.Password)][NotMapped]
        //NotMapped utilisée au niveau de l'application
        public string ConfirmPassword {
            get { return confirmPassword; }
            set
            {
                if (Password.Equals(value))
                {
                    confirmPassword = value;
                    Console.WriteLine("ACCEPTED");
                } else Console.WriteLine("Unmatching passwords");
            }
        }




        public string UserName { get; set; }

        public virtual List<Product> products { get; set; }

        //instantiation de la liste 
        public Provider()
        {
            this.products = new List<Product>();
        }

        public Provider(string confirmPassword, DateTime dateCreated, string email, int id, bool isApproved, string password, string userName, List<Product> products)
        {
            ConfirmPassword = confirmPassword;
            DateCreated = dateCreated;
            Email = email;
            Id = id;
            IsApproved = isApproved;
            Password = password;
            UserName = userName;
            this.products = products;
        }

        public static void SetIsApproved(Provider p){
            if(p.Password == p.ConfirmPassword)
            {
                p.IsApproved = true;
            }
            else
            {
                p.IsApproved = false;
            }
        }

        public static void SetIsApproved(string Password, string ConfirmPassword, bool IsApproved)
        {
            if (Password == ConfirmPassword)
            {
                IsApproved = true;
            }
            else
            {
                IsApproved = false;
            }
        }

        //public bool Login(string userName, string password)
        //{
        //    return (userName.Equals(UserName) && password.Equals(Password));
         
        //}
        //public bool Login(string userName, string password, string email)
        //{
        //    return (userName.Equals(UserName) && password.Equals(Password) && email.Equals(Email));

        //}

        //Fusionner les deux méthodes Login en une seule 
        //Parametre optionnel
        public bool Login(string userName, string password, string email=null)
        {
            if (email == null)
            {
                return (userName.Equals(UserName) && password.Equals(Password));
            }
            else return (userName.Equals(UserName) && password.Equals(Password) && email.Equals(Email));

        }

        public override void GetDetails()
        {
            Console.WriteLine($"{UserName}{Email}{Id}");
            Console.WriteLine("Product list: ");
            foreach(Product p in products)
            {
                p.GetDetails();
            }
        }

        public void GetProducts(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "DateProd":
                    foreach (Product p in products)
                    {
                        DateTime date = DateTime.Parse(filterValue) ;
                        DateTime.TryParse(filterValue,out date);

                        if (p.DateProd == date)
                        {
                            p.GetDetails();
                        }
                    }
                break;
               
                case "Price":
                    foreach (Product p in products)
                    {
                        Double prix = 0;
                        Double.TryParse(filterValue, out prix);

                        if (p.Price == prix)
                        {   
                            p.GetDetails();
                        }
                    }
                break;

            }


        }

    }
}
