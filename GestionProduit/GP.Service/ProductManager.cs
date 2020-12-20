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
        List<Product> products;

        public ProductManager(List<Product> products)
        {
            this.products = products;
            scan=ScanProduct;
            find = FindProduct;
        }


        public List<Product> FindProduct(String a)
        {
            //retourne l'indice de produit dont le nom commence par "c"*

            List<Product> newList = new List<Product>();
            foreach (Product p in products)
            {
                if (p.Name.StartsWith(a))
                {
                    newList.Add(p);
                }
            }
            return newList;
        }

        public void ScanProduct(Category c)
        {
            //retourne la liste de produits qui appartiennetn à une categorie donnée

            foreach (Product p in products)
            {
                if (p.category.Name.Equals(c))
                {
                    p.GetDetails();
                }
            }
        }

        public delegate List<Product> Find(String a);

        public delegate void Scan(Category c);

        public Scan scan;
        public Find find;
    }
}

