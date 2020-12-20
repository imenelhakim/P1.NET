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
    }
}
