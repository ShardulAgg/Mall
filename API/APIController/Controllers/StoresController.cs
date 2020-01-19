using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ObjectLibrary;
using APL;
namespace APIController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {

            //this.Id = id;
            //this.StoreName =name;
            //this.StoreDescription =desc;
            //this.StoreRating = rating;
            //this.StoreBannerUrl = url1;
            //this.StoreLogoUrl = url2;
        // GET: api/Stores
        [HttpGet]
        public IEnumerable<Store> Get()
        {
            var storeRepository = new StoreRepository();

            return storeRepository.GetStores();
        }

        // GET: api/Stores/5
        [HttpGet("{id}", Name = "Get")]
        public Store Get(int id)
        {
            var storeRepository = new StoreRepository();

            var stores = storeRepository.GetStores();
            return stores[id-1];
        }

        // POST: api/Stores
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Stores/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
