using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GP.Domain;

namespace GP.Service
{
    public class ProviderManager
    {
        List<Provider> providers;

        public ProviderManager(List<Provider> providers)
        {
            this.providers = providers;
        }

        public IEnumerable<Provider> GetProviderByName(string name)
        {
            //creation d'une var query from source de données + retourne un type enumerable 
            //var query = from p in providers
            //            where p.UserName.Contains(name)
            //            select p;
            //            //select new { p.Id , p.UserName };
            //return query;

            //utilisation des expression lambda
            return providers.Where(p => p.UserName.Contains(name));
        }
        public String GetFirstProviderByName(string name)
        {
            //var query = from p in providers
            //            where p.UserName.Contains(name)
            //            select p;
            ////select new { p.Id , p.UserName };
            //return query.FirstOrDefault(); //def car ne retourne pas d'elem

            ////utilisation des expression lambda
            //return providers.Where(p => p.UserName.Contains(name)).FirstOrDefault();
            return providers
                .Where(p => p.UserName
                .Contains(name))
                .Select(p=>p.UserName)
                .FirstOrDefault();

        }

        //return unique element
        public String GetProviderById(int id)
        {
            //var query = from p in providers
            //            where p.UserName.Contains(name)
            //            select p;
            ////select new { p.Id , p.UserName };
            //return query.FirstOrDefault(); //def car ne retourne pas d'elem

            ////utilisation des expression lambda
            //return providers.Where(p => p.UserName.Contains(name)).FirstOrDefault();
            return providers
                .Where(p => p.Id == id)
                .Select(p => p.UserName)
                .SingleOrDefault();
        }


    }
}
