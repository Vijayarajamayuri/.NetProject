using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResApplication.Models
{
    public class Restaurent
    {
        public int ID { get; set; }
        public string   RestaurentName { get; set; }
        public string RestaurentType { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Item> Item { get; set; }


    }
}