using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResApplication.Models
{
    public class Menu
    {

        public int MenuID { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public virtual ICollection<Item> Item{ get; set; }
    }
}