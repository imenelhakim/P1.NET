using GP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Service
{
    public static class Extention
    {
        public static void UpperName(this ProductManager pm,Product p)
        {
            p.Name.ToUpper();
        }
        //appel program.cs

        public static bool InCategory(this ProductManager pm, Product p, Category c)
        {
            return p.category.Name == c.Name;
        }
}
}
