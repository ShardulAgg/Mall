using System;
using System.Collections.Generic;
using System.Text;
using ObjectLibrary;
using Context;
using System.Linq;
using System.Threading.Tasks;
namespace APL
{
    public class StoreRepository 
    {
        public IList<Store> GetStores()
        {

            using (var context = new MallContext())
            {
                var stores = context.Stores.ToList();
                return stores;
            }
        }

        public IEnumerable<Store> GetStoreByCategory(string category)
        {
            using (var context = new MallContext())
            {
                var stores = context.Stores.ToList();
                return stores;
            }
        }

        public void AddStore(Store store)
        {
            using (var context = new MallContext())
            {
                context.Stores.Add(store);
                context.SaveChanges();
            }
        }
    }
}
