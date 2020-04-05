using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using ResApplication.Models;

namespace ResApplication.Data
{
    public class ResInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<ResContext>
    {
        protected override void Seed(ResContext context)
        {
            var restaurents = new List<Restaurent>
            {
            new Restaurent{RestaurentName="MCDonals",RestaurentType="FastFoood",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Restaurent{RestaurentName="Peri peri",RestaurentType="Italian",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Restaurent{RestaurentName="Burger King",RestaurentType="FastFood",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Restaurent{RestaurentName="PizzamANIA",RestaurentType="PizzaSpl",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Restaurent{RestaurentName="Dominos",RestaurentType="PizzaSpl",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Restaurent{RestaurentName="TaccoBell",RestaurentType="Mexican",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Restaurent{RestaurentName="GodFather Pizza",RestaurentType="Mexican",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Restaurent{RestaurentName="Love Love",RestaurentType="Indian",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            restaurents.ForEach(s => context.Restaurents.Add(s));
            context.SaveChanges();
            var menus = new List<Menu>
            {
            new Menu{MenuID=1050,Title="French Fries",Price=3,},
            new Menu{MenuID=4022,Title="Pizza",Price=10,},
            new Menu{MenuID=4041,Title="Burger",Price=3,},
            new Menu{MenuID=1045,Title="Chicken Nuggets",Price=8,},
            new Menu{MenuID=3141,Title="Pan Cakes",Price=4,},
            new Menu{MenuID=2021,Title="Ice Cream",Price=3,},
            new Menu{MenuID=2042,Title="SalsaChips",Price=12,}
            };
            menus.ForEach(s => context.Menu.Add(s));
            context.SaveChanges();
            var items = new List<Item>
            {
            new Item{RestaurentID=1,MenuID=1050,Rating=Rating.Excellent},
            new Item{RestaurentID=1,MenuID=4022,Rating=Rating.Average},
            new Item{RestaurentID=1,MenuID=4041,Rating=Rating.Bad},
            new Item{RestaurentID=2,MenuID=1045,Rating=Rating.VeryGood},
            new Item{RestaurentID=2,MenuID=3141,Rating=Rating.VeryPoor},
            new Item{RestaurentID=2,MenuID=2021,Rating=Rating.Good},
            new Item{RestaurentID=3,MenuID=1050},
            new Item{RestaurentID=4,MenuID=1050,},
            new Item{RestaurentID=4,MenuID=4022,Rating=Rating.Good},
            new Item{RestaurentID=5,MenuID=4041,Rating=Rating.Good},
            new Item{RestaurentID=6,MenuID=1045},
            new Item{RestaurentID=7,MenuID=3141,Rating=Rating.Bad},
            };
            items.ForEach(s => context.Item.Add(s));
            context.SaveChanges();
        }

        }
}