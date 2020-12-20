using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GP.Domain;

namespace GP.Service
{
    public class ProductManager
    {
        List<Product> productsM;

        public ProductManager(List<Product> productsM)
        {
            this.productsM = productsM;

            scan = delegate (Category c)
            {
                //retourne la liste de produits qui appartiennetn à une categorie donnée
                foreach (Product p in productsM)
                {
                    if (p.category.Name.Equals(c.Name))
                    {
                        p.GetDetails();
                    }
                }
            };

            //find = delegate (String a)
            //{
            //    //retourne l'indice de produit dont le nom commence par "c"*

            //    List<Product> newList = new List<Product>();
            //    foreach (Product p in productsM)
            //    {
            //        if (p.Name.StartsWith(a))
            //        {
            //            newList.Add(p);
            //        }
            //    }
            //    return newList;
            //};
        }


        //private List<Product> FindProduct(String a)
        //{
        //    //retourne l'indice de produit dont le nom commence par "c"*

        //    List<Product> newList = new List<Product>();
        //    foreach (Product p in productsM)
        //    {
        //        if (p.Name.StartsWith(a))
        //        {
        //            newList.Add(p);
        //        }
        //    }
        //    return newList;
        //}

        //private void ScanProduct(Category c)
        //{
        //    //retourne la liste de produits qui appartiennetn à une categorie donnée

        //    foreach (Product p in productsM)
        //    {
        //        if (p.category.Name.Equals(c.Name))
        //        {
        //            p.GetDetails();
        //        }
        //    }
        //}

        //public delegate List<Product> Find(String a);
        //public delegate void Scan(Category c);
        //public Scan scan; 
        //public Find find;

        //delegate generique : pointe vers des méthodes qui n'ont pas une valeur de retour
        //
      
        public Action<Category> scan;
        public Func<String,List<Product>> find;

        public List<Product> FindProduct(String a, Func<String, List<Product>> find)
        {
            return find(a);
        }

        public void ScanProduct(Category c)
        {
            scan(c);
        }

        //linq
        public IEnumerable<Product> Get5Chemical(double price)
        {
            var query = from p in productsM
                        where p is Chemical
                        select p;
            return query.Take(5);
        }

        public IEnumerable<Product> GetProductPrice(double price)
        {
            var query = from p in productsM
                        where p.Price > price
                        select p;
            return query.Skip(2);
        }

        public double GetAveragePrice()
        {
            var query = from p in productsM
                        select p.Price;
            return query.Average();
        }

        public double GetMaxPrice()
        {
            var query = from p in productsM
                        select p.Price;
            return query.Max();
        }

        public int GetCountProduct()
        {
            var query = from p in productsM
                        select p;
            return query.Count();
        }

        public IEnumerable<Product> GetChemicalCity()
        {
            var query = from p in productsM
                        where p is Chemical
                        orderby ((Chemical)p).City
                        select p;
            return query;
        }

        public void GetChemicalGroupByCity()
        {
            var query = from p in productsM
                        where p is Chemical
                        orderby ((Chemical)p).City
                        group p by ((Chemical)p).City;
            //req retourne un type e-grouping ( key + list )  > parcours
            foreach(var group in query)
            {
                Console.WriteLine(group.Key);
                foreach(var g in group)
                {
                    g.GetDetails();
                }
            }
        }
    }
}

