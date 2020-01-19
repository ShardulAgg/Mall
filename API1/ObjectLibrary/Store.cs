using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectLibrary
{
    public class Store
    {
        //public Store(int id, string name, string desc,int rating,string url1,string url2) {
            
        //    this.Id = id;
        //    this.StoreName =name;
        //    this.StoreDescription =desc;
        //    this.StoreRating = rating;
        //    this.StoreBannerUrl = url1;
        //    this.StoreLogoUrl = url2;
        //}
        public int Id { get; set; }

        public string StoreName { get; set; }

        public string StoreDescription { get; set; }

        public int StoreRating { get; set; }

        public string StoreBannerUrl { get; set; }

        public string StoreLogoUrl { get; set; }
        
        //public ICollection<StoreCategory> Categories { get; set; }
        public ICollection<Product> Products { get; set; }
        public Merchant Merchant { get; set; }
    }
}
