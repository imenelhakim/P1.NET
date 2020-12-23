using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GP.Domain;
using GP.Data;

using GP.Service;

namespace GP.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            /*----------------------------------- 21/12/2020 --------------------------------------------*/
            /*----------------------------------- S6 --------------------------------------------*/

            //Categories
            Category fruit = new Category() { CategoryId=1, Name = "Fruit" };
            Category Alimentaire = new Category() { CategoryId = 2, Name = "Alimentaire" };

            //Products

            Product cacaoNaturelle = new Chemical()
            {
                DateProd = new DateTime(2000, 12, 12),
                Name = "POUDRE DE CACAO NATURELLE",
                Description = "10% -12%",
                category = fruit,
                Price = 419,
                Quantity = 80
            };
            Product cacaoAlcalinisee = new Chemical()
            {
                DateProd = new DateTime(2000, 12, 12),
                Name = "POUDRE DE CACAO ALCALINISÉE",
                Description = "10% -12%",
                category = Alimentaire,
                Price = 60,
                Quantity = 300
            };
            Product dioxyde = new Chemical()
            {
                DateProd = new DateTime(2000, 12, 12),
                Name = "DIOXYDE DE TITANE",
                Description = "TiO2 grade alimentaire, cosmétique et pharmaceutique.",
                category = Alimentaire,
                Price = 200,
                Quantity = 50
            };
            Product amidon = new Chemical()
            {
                DateProd = new DateTime(2000, 12, 12),
                Name = "AMIDON DE MAÏS",
                Description = "Amidon de maïs natif",
                category = Alimentaire,
                Price = 70,
                Quantity = 30
            };
            Product blackberry = new Biological()
            {
                DateProd = new DateTime(2000, 12, 12),
                Name = "Blackberry",
                Description = "",
                category = fruit,
                Price = 60,
                ProductId = 0,
                Quantity = 0

            };

            Product apple = new Biological()
            {
                DateProd = new DateTime(2000, 12, 12),
                Description = "",
                category = Alimentaire,
                Name = "Apple",
                Price = 100.00,
                ProductId = 0,
                Quantity = 100

            };

            List<Product> products = new List<Product>() { apple, dioxyde, amidon, cacaoAlcalinisee, blackberry, cacaoNaturelle };




            //instanciation de la classe gpcontest 
            Model1 context = new Model1(); 
            context.Products.AddRange(products); //ajouter une liste de produits  
            System.Console.WriteLine("ok");
            context.SaveChanges(); //assure la persistance de données

            //selection de touts les produits 
            var query = from p in context.Products  //contient la liste des produits 
                        select p;
            //afficher la categorie du premier produit sauvergardé dans la base
            var prod = query.First();   

            var cat = prod.category;
            System.Console.WriteLine("Produit");
            prod.GetDetails();
            System.Console.WriteLine("Categorie du Produit");
            cat.GetDetails();


            System.Console.ReadKey();

            /*----------------------------------- 20/12/2020 --------------------------------------------*/
            /*----------------------------------- DB --------------------------------------------*/

            ////instanciation de la classe gpcontest 
            //Model1 context = new Model1();
            ////persistance de données
            //Product p1 = new Product()
            //{
            //    Name = "Bracelet",
            //    DateProd = DateTime.Now,
            //    Price = 60,
            //    Quantity = 10

            //};

            //context.products.Add(p1);
            //System.Console.WriteLine("ok");
            //context.SaveChanges(); //assure la persistance de données

            //System.Console.WriteLine("ok1");


            ///*----------------------------------- 20/12/2020 --------------------------------------------*/
            ///*----------------------------------- DELEGATES --------------------------------------------*/

            ////1-add referrence GP.Service 
            ////2-using GP.Service;
            ////3-creation de la liste des produits
            ////Categories
            //Category fruit = new Category() { Name = "Fruit" };
            //Category Alimentaire = new Category() { Name = "Alimentaire" };

            ////Products

            //Product cacaoNaturelle = new Chemical()
            //{
            //    DateProd = new DateTime(2000, 12, 12),
            //    Name = "POUDRE DE CACAO NATURELLE",
            //    Description = "10% -12%",
            //    category = Alimentaire,
            //    Price = 419,
            //    Quantity = 80
            //};
            //Product cacaoAlcalinisee = new Chemical()
            //{
            //    DateProd = new DateTime(2000, 12, 12),
            //    Name = "POUDRE DE CACAO ALCALINISÉE",
            //    Description = "10% -12%",
            //    category = Alimentaire,
            //    Price = 60,
            //    Quantity = 300
            //};
            //Product dioxyde = new Chemical()
            //{
            //    DateProd = new DateTime(2000, 12, 12),
            //    Name = "DIOXYDE DE TITANE",
            //    Description = "TiO2 grade alimentaire, cosmétique et pharmaceutique.",
            //    category = Alimentaire,
            //    Price = 200,
            //    Quantity = 50
            //};
            //Product amidon = new Chemical()
            //{
            //    DateProd = new DateTime(2000, 12, 12),
            //    Name = "AMIDON DE MAÏS",
            //    Description = "Amidon de maïs natif",
            //    category = Alimentaire,
            //    Price = 70,
            //    Quantity = 30
            //};
            //Product blackberry = new Biological()
            //{
            //    DateProd = new DateTime(2000, 12, 12),
            //    Name = "Blackberry",
            //    Description = "",
            //    category = fruit,
            //    Price = 60,
            //    ProductId = 0,
            //    Quantity = 0

            //};

            //Product apple = new Biological()
            //{
            //    DateProd = new DateTime(2000, 12, 12),
            //    Description = "",
            //    category = fruit,
            //    Name = "Apple",
            //    Price = 100.00,
            //    ProductId = 0,
            //    Quantity = 100

            //};

            //List<Product> products = new List<Product>() { dioxyde, amidon, cacaoAlcalinisee, blackberry, apple, cacaoNaturelle };

            //ProductManager pm = new ProductManager(products);
            ////pm.scan(fruit);
            ////pm.find("A");

            //pm.scan(fruit);

            //pm.FindProduct(
            //    "a",
            //    //delegate (String a)
            //    (String a) =>
            //    {
            //        //retourne l'indice de produit dont le nom commence par "c"*

            //        List<Product> newList = new List<Product>();
            //        foreach (Product p in products)
            //        {
            //            if (p.Name.StartsWith(a))
            //            {
            //                newList.Add(p);
            //            }
            //        }
            //        return newList;
            //    }

            //    );

            //pm.UpperName(apple);




            /////*----------------------------------- 20/12/2020 --------------------------------------------*/






            //// TP 

            ////Product p = new Product();
            ////p.Quantity=10;
            ////System.Console.WriteLine(p.Quantity);
            ////System.Console.ReadKey();

            ////c.i
            //Provider P1 = new Provider() { UserName="manou", Password = "imen123", ConfirmPassword = "imen123", Email= "imen.ehk@esprit.tn"};
            //Provider P2 = new Provider() { UserName = "lili", Password = "lili123", ConfirmPassword = "lili123", Email = "lili.ehk@esprit.tn" };

            //System.Console.WriteLine(P1.Login("manou", "imen123", "imen.ehk@esprit.tn"));
            //System.Console.WriteLine(P1.Login("manou", "123"));


            //Provider.SetIsApproved(P1.Password, P1.ConfirmPassword, P1.IsApproved);
            //System.Console.WriteLine("{" +P1.Password+ ";" +P1.ConfirmPassword+ ";" +P1.IsApproved+ "}");
            //System.Console.ReadKey();

            //Provider.SetIsApproved(P2);
            //System.Console.WriteLine("{" + P2.Password + ";" + P2.ConfirmPassword + ";" + P2.IsApproved + "}");
            //System.Console.ReadKey();

            ////virtual+overrride


            //Product p = new Product();
            //Chemical c = new Chemical();
            //Biological b = new Biological();

            //p.GetMyType();
            //c.GetMyType();
            //b.GetMyType();


            ////objet.liste.Add(product)
            //Product pr = new Product(DateTime.Now, "Shampoo", "Cheveux secs", 1, 5, 25);
            //Product pro = new Product(DateTime.Now, "Demelant", "Cheveux secs", 2, 25, 25);

            //P1.products.Add(pr);
            //P1.products.Add(pro);
            ////P1.GetDetails();




            ////getproducts 
            //P1.GetProducts("Price", "25");
            //System.Console.WriteLine("----");

            //////Scénario de test
            ////Categories / Providers    CAT1              CAT2        CAT3        NULL
            ////PROV1                     PROD1, PROD2                  PROD3
            ////PROV2                     PROD1             PROD5
            ////PROV3                     PROD1                                     PROD4
            ////PROV4                                                   PROD6       PROD4
            ////PROV5                                                   PROD6       PROD4

            //Category cat1 = new Category() { Name = "CAT1" };
            //Category cat2 = new Category() { Name = "CAT2" };
            //Category cat3 = new Category() { Name = "CAT3" };
            //Provider prov1 = new Provider() { UserName = "PROV1" };
            //Provider prov2 = new Provider() { UserName = "PROV2" };
            //Provider prov3 = new Provider() { UserName = "PROV3" };
            //Provider prov4 = new Provider() { UserName = "PROV4" };
            //Provider prov5 = new Provider() { UserName = "PROV5" };
            //Product prod1 = new Product() { Name = "PROD1", category = cat1, providers = new List<Provider>() { prov1, prov2, prov3 } };
            //Product prod2 = new Product() { Name = "PROD2", category = cat1, providers = new List<Provider>() { prov1 } };
            //Product prod3 = new Product() { Name = "PROD3", category = cat3, providers = new List<Provider>() { prov1 } };
            //Product prod4 = new Product() { Name = "PROD4", providers = new List<Provider>() { prov3, prov4, prov5 } };
            //Product prod5 = new Product() { Name = "PROD5", category = cat2, providers = new List<Provider>() { } };
            //Product prod6 = new Product() { Name = "PROD6", category = cat3, providers = new List<Provider>() { prov4, prov5 } };



            //cat1.products = new List<Product>() { prod1, prod2 };
            //cat2.products = new List<Product>() { prod5 };
            //cat3.products = new List<Product>() { prod3, prod6 };
            //prov1.products = new List<Product>() { prod1, prod2, prod3 };
            //prov2.products = new List<Product>() { prod1, prod5 };
            //prov3.products = new List<Product>() { prod1 };
            //prov4.products = new List<Product>() { prod4, prod6 };
            //prov5.products = new List<Product>() { prod4, prod6 };

            //System.Console.WriteLine("détails des providers");
            //prov1.GetDetails();
            //prov2.GetDetails();
            //prov3.GetDetails();
            //prov4.GetDetails();
            //prov5.GetDetails();
            //System.Console.ReadKey();


            ////int a =5 ;
            ////System.Console.WriteLine(a);

            ////var b = "Hello";
            ////System.Console.WriteLine(b.GetType());

            ////System.Console.ReadKey();



        }
    }
}
