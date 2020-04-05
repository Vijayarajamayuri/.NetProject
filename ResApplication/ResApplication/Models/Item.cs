using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResApplication.Models
{



  
    public enum Rating
    {
        Excellent,VeryGood,Good,Average,Bad,VeryPoor
    }
   
    public class Item
    {

        public int ItemID { get; set; }
        public int MenuID { get; set; }
        public int RestaurentID { get; set; }
        public Rating? Rating { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual Restaurent Restaurent { get; set; }
    }
}